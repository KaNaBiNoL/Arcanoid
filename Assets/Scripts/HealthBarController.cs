using UnityEngine;

public class HealthBarController : SingletonMonoBehaviour<HealthBarController>
{
    #region Variables

    [SerializeField] private SpriteRenderer[] _hpSpriteRenderers;
    [SerializeField] private Sprite[] _healthSprites;

    #endregion


    #region Public methods

    public void SwitchHealthImage()
    {
        switch (GameManager.Instance._playerHealth)
        {
            case 3:
                SetImage(_hpSpriteRenderers, _healthSprites, 0, 0, 0);
                break;
            case 2:
                SetImage(_hpSpriteRenderers, _healthSprites, 0, 0, 1);
                break;
            case 1:
                SetImage(_hpSpriteRenderers, _healthSprites, 0, 1, 1);
                break;
            case 0:
                SetImage(_hpSpriteRenderers, _healthSprites, 1, 1, 1);
                break;
        }
    }

    #endregion


    #region Private methods

    private void SetImage(SpriteRenderer[] spriteRenderers, Sprite[] sprites, int index1, int index2, int index3)
    {
        spriteRenderers = _hpSpriteRenderers;
        sprites = _healthSprites;
        spriteRenderers[0].sprite = sprites[index1];
        spriteRenderers[1].sprite = sprites[index2];
        spriteRenderers[2].sprite = sprites[index3];
    }

    #endregion
}