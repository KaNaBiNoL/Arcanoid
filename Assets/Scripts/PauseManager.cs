using System;
using UnityEngine;

public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
   #region Variables

   public bool _isPaused;

   #endregion


   #region Unity lifecycle

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         TogglePause();
      }
   }

   #endregion


   #region Private methods

   private void TogglePause()
   {
      _isPaused = !_isPaused;
      Time.timeScale = _isPaused ? 0 : 1;
   }

   #endregion
}
