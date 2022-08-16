using UnityEngine;

public class LevelManager : SingletonMonoBehaviour<LevelManager>
{
    #region Variables

    private int _blocksCount;

    #endregion


    #region Unity lifecycle

    private void Start()
    {
        BlockBase[] blocks = FindObjectsOfType<BlockBase>();
        _blocksCount = blocks.Length;

        foreach (BlockBase block in blocks)
        {
            Debug.Log($"Subscribe on block '{block.gameObject.name}'");
            block.OnDestroyed += BlockDestroyed;
        }
    }

    #endregion


    #region Private methods

    private void BlockDestroyed(BlockBase block)
    {
        block.OnDestroyed -= BlockDestroyed;
        _blocksCount--;
        if (_blocksCount == 0)
        {
            GameManager.Instance.PerformWin();
        }
    }

    #endregion
}