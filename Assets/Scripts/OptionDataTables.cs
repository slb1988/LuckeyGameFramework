using System;
using System.Collections.Generic;

public class OptionDataTables
{
    public static readonly Dictionary<Option, object> s_defaultsMap;
    public static readonly Dictionary<Option, System.Type> s_typeMap;

    static OptionDataTables()
    {
        Dictionary<Option, System.Type> dictionary = new Dictionary<Option, System.Type>();
        dictionary.Add(Option.SOUND, typeof(bool));
        dictionary.Add(Option.MUSIC, typeof(bool));
        dictionary.Add(Option.CURSOR, typeof(bool));
        dictionary.Add(Option.HUD, typeof(bool));
        dictionary.Add(Option.STREAMING, typeof(bool));
        dictionary.Add(Option.SOUND_VOLUME, typeof(float));
        dictionary.Add(Option.MUSIC_VOLUME, typeof(float));
        dictionary.Add(Option.GFX_WIDTH, typeof(int));
        dictionary.Add(Option.GFX_HEIGHT, typeof(int));
        dictionary.Add(Option.GFX_FULLSCREEN, typeof(bool));
        dictionary.Add(Option.HAS_SEEN_CINEMATIC, typeof(bool));
        dictionary.Add(Option.GFX_QUALITY, typeof(int));
        dictionary.Add(Option.FAKE_PACK_OPENING, typeof(bool));
        dictionary.Add(Option.FAKE_PACK_COUNT, typeof(int));
        dictionary.Add(Option.HEALTHY_GAMING_DEBUG, typeof(bool));
        dictionary.Add(Option.LAST_SCENE_MODE, typeof(int));
        dictionary.Add(Option.LOCALE, typeof(int));
        dictionary.Add(Option.IDLE_KICKER, typeof(bool));
        dictionary.Add(Option.IDLE_KICK_TIME, typeof(string));
        dictionary.Add(Option.BACKGROUND_SOUND, typeof(bool));
        dictionary.Add(Option.PREFERRED_REGION, typeof(int));
        dictionary.Add(Option.NEARBY_PLAYERS, typeof(bool));
        dictionary.Add(Option.GFX_WIN_CAMERA_CLEAR, typeof(bool));
        dictionary.Add(Option.GFX_MSAA, typeof(int));
        dictionary.Add(Option.GFX_FXAA, typeof(bool));
        dictionary.Add(Option.GFX_TARGET_FRAME_RATE, typeof(int));
        dictionary.Add(Option.GFX_VSYNC, typeof(int));
        dictionary.Add(Option.GFX_SHOW_FPS, typeof(bool));
        dictionary.Add(Option.PAGE_MOUSE_OVERS, typeof(int));
        dictionary.Add(Option.COVER_MOUSE_OVERS, typeof(int));
        dictionary.Add(Option.LAST_PRECON_HERO_CHOSEN, typeof(int));
        dictionary.Add(Option.AI_MODE, typeof(int));
        dictionary.Add(Option.TIP_PRACTICE_PROGRESS, typeof(int));
        dictionary.Add(Option.TIP_PLAY_PROGRESS, typeof(int));
        dictionary.Add(Option.TIP_FORGE_PROGRESS, typeof(int));
        dictionary.Add(Option.LAST_CUSTOM_DECK_CHOSEN, typeof(long));
        s_typeMap = dictionary;
        Dictionary<Option, object> dictionary2 = new Dictionary<Option, object>();
        dictionary2.Add(Option.SOUND, true);
        dictionary2.Add(Option.MUSIC, true);
        dictionary2.Add(Option.CURSOR, true);
        dictionary2.Add(Option.HUD, true);
        dictionary2.Add(Option.STREAMING, true);
        dictionary2.Add(Option.SOUND_VOLUME, 1f);
        dictionary2.Add(Option.MUSIC_VOLUME, 0.5f);
        dictionary2.Add(Option.GFX_QUALITY, 1);
        dictionary2.Add(Option.LOCALE, -1);
        dictionary2.Add(Option.IDLE_KICKER, true);
        dictionary2.Add(Option.IDLE_KICK_TIME, "30 min");
        dictionary2.Add(Option.BACKGROUND_SOUND, true);
        dictionary2.Add(Option.PREFERRED_REGION, -1);
        dictionary2.Add(Option.NEARBY_PLAYERS, false);
        dictionary2.Add(Option.IN_RANKED_PLAY_MODE, false);
        s_defaultsMap = dictionary2;
    }
}
