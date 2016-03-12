using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume (float volume) {
        PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
    }

    public static float GetMasterVolume () {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level) {
        // 1 = true, 0 = false
        PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
    }

    public static bool IsLevelUnlocked(int level) {
        if (PlayerPrefs.GetInt(LEVEL_KEY + level.ToString()) == 1) {
            return true;
        } else {
            return false;
        }
    }

    public static void SetDifficulty(float difficulty) {

        if (difficulty < 0 || difficulty > 1) {
            Debug.LogError("Difficulty must be between 0 and 1");
        } else {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
    }

    public static float GetDifficulty() {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
