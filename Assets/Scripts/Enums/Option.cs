using System;
using System.ComponentModel;

public enum ServerOption
{
    AI_MODE = 9,
    COVER_MOUSE_OVERS = 7,
    FLAGS1 = 1,
    FLAGS10 = 0x11,
    FLAGS2 = 2,
    FLAGS3 = 3,
    FLAGS4 = 4,
    FLAGS5 = 5,
    FLAGS6 = 13,
    FLAGS7 = 14,
    FLAGS8 = 15,
    FLAGS9 = 0x10,
    INVALID = 0,
    LAST_CUSTOM_DECK_CHOSEN = 0x12,
    LAST_PRECON_HERO_CHOSEN = 8,
    LIMIT = 0x33,
    PAGE_MOUSE_OVERS = 6,
    TIP_FORGE_PROGRESS = 12,
    TIP_PLAY_PROGRESS = 11,
    TIP_PRACTICE_PROGRESS = 10
}

public enum ServerOptionFlag
{
    HAS_ACKED_ARENA_REWARDS = 0x2d,
    HAS_ADDED_CARDS_TO_DECK = 0x20,
    HAS_BEEN_NUDGED_TO_CM = 0x1f,
    HAS_BEEN_NUDGED_TO_PLAY = 30,
    HAS_CLICKED_TOURNAMENT = 0,
    HAS_CLICKED_UNRANKED_PLAY = 0x1d,
    HAS_CRAFTED = 40,
    HAS_DISENCHANTED = 0x25,
    HAS_FINISHED_A_DECK = 9,
    HAS_LOST_IN_ARENA = 0x2b,
    HAS_OPENED_BOOSTER = 1,
    HAS_PLAYED_EXPERT_AI = 0x24,
    HAS_RUN_OUT_OF_QUESTS = 0x2c,
    HAS_SAVED_A_CUSTOM_DECK = 0x22,
    HAS_SEEN_100g_REMINDER = 0x17,
    HAS_SEEN_ALL_BASIC_CLASS_CARDS_COMPLETE = 0x1c,
    HAS_SEEN_COLLECTIONMANAGER = 3,
    HAS_SEEN_CRAFTING_INSTRUCTION = 0x27,
    HAS_SEEN_CUSTOM_DECK_PICKER = 0x1b,
    HAS_SEEN_DECK_HELPER = 0x18,
    HAS_SEEN_EXPERT_AI = 0x15,
    HAS_SEEN_EXPERT_AI_UNLOCK = 0x16,
    HAS_SEEN_FORGE = 11,
    HAS_SEEN_FORGE_1WIN = 0x10,
    HAS_SEEN_FORGE_2LOSS = 0x12,
    HAS_SEEN_FORGE_CARD_CHOICE = 13,
    HAS_SEEN_FORGE_CARD_CHOICE2 = 14,
    HAS_SEEN_FORGE_HERO_CHOICE = 12,
    HAS_SEEN_FORGE_PLAY_MODE = 15,
    HAS_SEEN_FORGE_RETIRE = 0x13,
    HAS_SEEN_GOLD_QTY_INSTRUCTION = 0x21,
    HAS_SEEN_HUB = 7,
    HAS_SEEN_LEVEL_3 = 0x2a,
    HAS_SEEN_MULLIGAN = 20,
    HAS_SEEN_NEW_MEDAL = 8,
    HAS_SEEN_PACK_OPENING = 0x19,
    HAS_SEEN_PRACTICE_MODE = 0x1a,
    HAS_SEEN_PRACTICE_TRAY = 6,
    HAS_SEEN_SHOW_ALL_CARDS_REMINDER = 0x26,
    HAS_SEEN_THE_COIN = 0x11,
    HAS_SEEN_TOURNAMENT = 2,
    HAS_SEEN_UNOWNED_CARDS = 10,
    IN_RANKED_PLAY_MODE = 0x29,
    JUST_FINISHED_TUTORIAL = 4,
    LIMIT = 0x141,
    SHOW_ADVANCED_COLLECTIONMANAGER = 5,
    TIP_CRAFTING_UNLOCKED = 0x23
}

public enum ClientOption
{
    INVALID,
    SOUND,
    MUSIC,
    CURSOR,
    HUD,
    STREAMING,
    SOUND_VOLUME,
    MUSIC_VOLUME,
    GFX_WIDTH,
    GFX_HEIGHT,
    GFX_FULLSCREEN,
    HAS_SEEN_CINEMATIC,
    GFX_QUALITY,
    FAKE_PACK_OPENING,
    FAKE_PACK_COUNT,
    HEALTHY_GAMING_DEBUG,
    LAST_SCENE_MODE,
    LOCALE,
    IDLE_KICKER,
    IDLE_KICK_TIME,
    BACKGROUND_SOUND,
    PREFERRED_REGION,
    NEARBY_PLAYERS,
    GFX_WIN_CAMERA_CLEAR,
    GFX_MSAA,
    GFX_FXAA,
    GFX_TARGET_FRAME_RATE,
    GFX_VSYNC,
    GFX_SHOW_FPS
}

public enum Option
{
    [Description("aimode")]
    AI_MODE = 0x1f,
    [Description("backgroundsound")]
    BACKGROUND_SOUND = 20,
    [Description("covermouseovers")]
    COVER_MOUSE_OVERS = 30,
    [Description("cursor")]
    CURSOR = 3,
    [Description("hasUnlockedCrafting")]
    DEPRECATED_HAS_UNLOCKED_CRAFTING = 0x45,
    [Description("hasUnlockedForge")]
    DEPRECATED_HAS_UNLOCKED_FORGE = 0x44,
    [Description("fakepackcount")]
    FAKE_PACK_COUNT = 14,
    [Description("fakepackopening")]
    FAKE_PACK_OPENING = 13,
    [Description("graphicsfullscreen")]
    GFX_FULLSCREEN = 10,
    [Description("fxaa")]
    GFX_FXAA = 0x19,
    [Description("graphicsheight")]
    GFX_HEIGHT = 9,
    [Description("msaa")]
    GFX_MSAA = 0x18,
    [Description("graphicsquality")]
    GFX_QUALITY = 12,
    [Description("showfps")]
    GFX_SHOW_FPS = 0x1c,
    [Description("targetframerate")]
    GFX_TARGET_FRAME_RATE = 0x1a,
    [Description("vsync")]
    GFX_VSYNC = 0x1b,
    [Description("graphicswidth")]
    GFX_WIDTH = 8,
    [Description("wincameraclear")]
    GFX_WIN_CAMERA_CLEAR = 0x17,
    [Description("hasAckedArenaRewards")]
    HAS_ACKED_ARENA_REWARDS = 0x54,
    [Description("hasAddedCardsToDeck")]
    HAS_ADDED_CARDS_TO_DECK = 0x43,
    [Description("hasBeenNudgedToCM")]
    HAS_BEEN_NUDGED_TO_CM = 0x42,
    [Description("hasBeenNudgedToPlay")]
    HAS_BEEN_NUDGED_TO_PLAY = 0x41,
    [Description("hasclickedtournament")]
    HAS_CLICKED_TOURNAMENT = 0x25,
    [Description("hasClickedUnrankedPlay")]
    HAS_CLICKED_UNRANKED_PLAY = 0x40,
    [Description("hasCrafted")]
    HAS_CRAFTED = 0x4b,
    [Description("hasDisenchanted")]
    HAS_DISENCHANTED = 0x48,
    [Description("firstdeckcomplete")]
    HAS_FINISHED_A_DECK = 0x2e,
    [Description("hasLostInArena")]
    HAS_LOST_IN_ARENA = 0x52,
    [Description("hasopenedbooster")]
    HAS_OPENED_BOOSTER = 0x26,
    [Description("hasPlayedExpertAI")]
    HAS_PLAYED_EXPERT_AI = 0x47,
    [Description("hasRunOutOfQuests")]
    HAS_RUN_OUT_OF_QUESTS = 0x53,
    [Description("hasSavedACustomDeck")]
    HAS_SAVED_A_CUSTOM_DECK = 80,
    [Description("hasseen100goldReminder")]
    HAS_SEEN_100g_REMINDER = 0x4e,
    [Description("hasSeenAllBasicClassCardsComplete")]
    HAS_SEEN_ALL_BASIC_CLASS_CARDS_COMPLETE = 0x3f,
    [Description("hasseencinematic")]
    HAS_SEEN_CINEMATIC = 11,
    [Description("hasseencollectionmanager")]
    HAS_SEEN_COLLECTIONMANAGER = 40,
    [Description("hasSeenCraftingInstruction")]
    HAS_SEEN_CRAFTING_INSTRUCTION = 0x4a,
    [Description("hasSeenCustomDeckPicker")]
    HAS_SEEN_CUSTOM_DECK_PICKER = 0x3e,
    [Description("hasseendeckhelper")]
    HAS_SEEN_DECK_HELPER = 0x3b,
    [Description("hasSeenExpertAI")]
    HAS_SEEN_EXPERT_AI = 0x39,
    [Description("hasSeenExpertAIUnlock")]
    HAS_SEEN_EXPERT_AI_UNLOCK = 0x3a,
    [Description("hasseenforge")]
    HAS_SEEN_FORGE = 0x30,
    [Description("hasseenforge1win")]
    HAS_SEEN_FORGE_1WIN = 0x35,
    [Description("hasseenforge2loss")]
    HAS_SEEN_FORGE_2LOSS = 0x36,
    [Description("hasseenforgecardchoice")]
    HAS_SEEN_FORGE_CARD_CHOICE = 50,
    [Description("hasseenforgecardchoice2")]
    HAS_SEEN_FORGE_CARD_CHOICE2 = 0x33,
    [Description("hasseenforgeherochoice")]
    HAS_SEEN_FORGE_HERO_CHOICE = 0x31,
    [Description("hasseenforgeplaymode")]
    HAS_SEEN_FORGE_PLAY_MODE = 0x34,
    [Description("hasseenforgeretire")]
    HAS_SEEN_FORGE_RETIRE = 0x37,
    [Description("hasSeenGoldQtyInstruction")]
    HAS_SEEN_GOLD_QTY_INSTRUCTION = 0x4f,
    [Description("firstHubVisitPastTutorial")]
    HAS_SEEN_HUB = 0x2c,
    [Description("hasSeenLevel3")]
    HAS_SEEN_LEVEL_3 = 0x51,
    [Description("hasseenmulligan")]
    HAS_SEEN_MULLIGAN = 0x38,
    [Description("firstnewmedalearned")]
    HAS_SEEN_NEW_MEDAL = 0x2d,
    [Description("hasSeenPackOpening")]
    HAS_SEEN_PACK_OPENING = 60,
    [Description("hasSeenPracticeMode")]
    HAS_SEEN_PRACTICE_MODE = 0x3d,
    [Description("hasseenpracticetray")]
    HAS_SEEN_PRACTICE_TRAY = 0x2b,
    [Description("hasSeenShowAllCardsReminder")]
    HAS_SEEN_SHOW_ALL_CARDS_REMINDER = 0x49,
    [Description("hasSeenTheCoin")]
    HAS_SEEN_THE_COIN = 0x4d,
    [Description("hasseentournament")]
    HAS_SEEN_TOURNAMENT = 0x27,
    [Description("clickedshowcardsidontown")]
    HAS_SEEN_UNOWNED_CARDS = 0x2f,
    [Description("healthygamingdebug")]
    HEALTHY_GAMING_DEBUG = 15,
    [Description("hud")]
    HUD = 4,
    [Description("idlekicktime")]
    IDLE_KICK_TIME = 0x13,
    [Description("idlekicker")]
    IDLE_KICKER = 0x12,
    [Description("inRankedPlayMode")]
    IN_RANKED_PLAY_MODE = 0x4c,
    INVALID = 0,
    [Description("justfinishedtutorial")]
    JUST_FINISHED_TUTORIAL = 0x29,
    [Description("lastChosenCustomDeck")]
    LAST_CUSTOM_DECK_CHOSEN = 0x24,
    [Description("lastChosenPreconHero")]
    LAST_PRECON_HERO_CHOSEN = 0x23,
    [Description("laststate")]
    LAST_SCENE_MODE = 0x10,
    [Description("locale")]
    LOCALE = 0x11,
    [Description("music")]
    MUSIC = 2,
    [Description("musicvolume")]
    MUSIC_VOLUME = 7,
    [Description("nearbyplayers")]
    NEARBY_PLAYERS = 0x16,
    [Description("pagemouseovers")]
    PAGE_MOUSE_OVERS = 0x1d,
    [Description("preferredregion")]
    PREFERRED_REGION = 0x15,
    [Description("showadvancedcollectionmanager")]
    SHOW_ADVANCED_COLLECTIONMANAGER = 0x2a,
    [Description("sound")]
    SOUND = 1,
    [Description("soundvolume")]
    SOUND_VOLUME = 6,
    [Description("streaming")]
    STREAMING = 5,
    [Description("tipCraftingUnlocked")]
    TIP_CRAFTING_UNLOCKED = 70,
    [Description("forgetipprogress")]
    TIP_FORGE_PROGRESS = 0x22,
    [Description("playtipprogress")]
    TIP_PLAY_PROGRESS = 0x21,
    [Description("practicetipporgress")]
    TIP_PRACTICE_PROGRESS = 0x20
}

