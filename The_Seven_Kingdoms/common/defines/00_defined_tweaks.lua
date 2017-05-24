-- Format for overwriting define values:
--
-- NDefines.NDiplomacy.DEMESNE_BASE_MAX_SIZE = 2.0

-- Diplomacy
NDefines.NDiplomacy.VASSAL_LIMIT_LEVY_MULTIPLIER = 0
NDefines.NDiplomacy.LAW_CHANGE_PRESTIGE_COST = 150 -- from 100
NDefines.NDiplomacy.CROWN_LAW_CHANGE_PRESTIGE_COST = 300 -- from 200
NDefines.NDiplomacy.BASE_REVOLT_CHANCE_MOD = 200 -- from 250
NDefines.NDiplomacy.DUKE_POWERFUL_VASSAL_COUNT = 3 -- from 4
NDefines.NDiplomacy.KING_POWERFUL_VASSAL_COUNT = 4 -- from 5
NDefines.NDiplomacy.EMPEROR_POWERFUL_VASSAL_COUNT = 5 -- from 6
NDefines.NDiplomacy.IMPRISON_CHARACTER_INTERACTION_PIETY = 0 -- Reduced from 10
NDefines.NDiplomacy.EXECUTE_IMPRISONED_INTERACTION_PIETY = 10 -- Reduced from 20
NDefines.NDiplomacy.DEMAND_RELIGIOUS_CONVERSION_INTERACTION_PIETY = 25 -- Increased from 0
NDefines.NDiplomacy.DEMAND_RELIGIOUS_CONVERSION_INTERACTION_PRESTIGE = 50 -- Increased from 0

NDefines.NDiplomacy.MAX_DIPLO_DISTANCE = 1500

-- Council
NDefines.NCouncil.ENFORCE_PEACE_START_DELAY = 6 -- from 3
NDefines.NCouncil.LAW_VOTE_CHANGE_TIME_LIMIT = 2 -- from 1

-- Titles
NDefines.NTitle.BARON_LANDLESS_SON_PRESTIGE = 0.005
NDefines.NTitle.COUNT_LANDLESS_SON_PRESTIGE = 0.05
NDefines.NTitle.DUKE_LANDLESS_SON_PRESTIGE = 0.1
NDefines.NTitle.KING_LANDLESS_SON_PRESTIGE = 0.2
NDefines.NTitle.EMPEROR_LANDLESS_SON_PRESTIGE = 0.4

-- Characters

NDefines.NCharacter.CHANGE_AMBITION_YEARS = 2 -- from 3
NDefines.NCharacter.CHANGE_FOCUS_YEARS = 4 -- from 5

NDefines.NCharacter.MAX_JOINED_FACTIONS = 4

NDefines.NCharacter.PRESTIGE_FROM_DYNASTY_ON_BIRTH_DIV = 15
NDefines.NCharacter.PRESTIGE_FROM_DYNASTY_ON_MARRIAGE_DIV = 15

NDefines.NCharacter.PORTRAIT_ADULT_MALE_AGE_THRESHOLD = 15
NDefines.NCharacter.PORTRAIT_ADULT_FEMALE_AGE_THRESHOLD = 15

NDefines.NCharacter.PORTRAIT_MID_AGE_THRESHOLD = 30
NDefines.NCharacter.PORTRAIT_OLD_AGE_THRESHOLD = 50

NDefines.NCharacter.AGE_OF_ADULTHOOD_MALE = 15
NDefines.NCharacter.AGE_OF_ADULTHOOD_FEMALE = 15
NDefines.NCharacter.AGE_OF_MARRIAGE_MALE = 14
NDefines.NCharacter.AGE_OF_MARRIAGE_FEMALE = 14

NDefines.NCharacter.AGE_ADOLESCENT = 12
NDefines.NCharacter.AGE_YOUNG = 20
NDefines.NCharacter.AGE_ADULT = 34
NDefines.NCharacter.AGE_OLD = 58
NDefines.NCharacter.AGE_VERY_OLD = 70

NDefines.NCharacter.MAX_CHILD_BIRTH_AGE = 48

NDefines.NCharacter.NATURAL_DEATH_CHANCE_AGE_50 = 70
NDefines.NCharacter.NATURAL_DEATH_CHANCE_AGE_60 = 200
NDefines.NCharacter.NATURAL_DEATH_CHANCE_AGE_70 = 550
NDefines.NCharacter.NATURAL_DEATH_CHANCE_AGE_80 = 2400
NDefines.NCharacter.NATURAL_DEATH_CHANCE_AGE_90 = 4000

NDefines.NCharacter.INFANT_DEATH_CHANCE = 0.03

NDefines.NCharacter.FEMALE_ATTRACTION_CUTOFF = 48

-- Religion
NDefines.NReligion.AUTHORITY_FROM_ORG_RELIGION = 0.3

-- Economy
NDefines.NEconomy.BISHOP_TAX_TO_POPE_FACTOR = 0.15 -- from 0.1
NDefines.NEconomy.TRADE_POST_COST_INC_DIST = 0.0045
NDefines.NEconomy.OVER_MAX_DEMESNE_TAX_PENALTY = 0.05 -- reduced penalty from 20%

-- Military

NDefines.NMilitary.MAX_COMMANDERS_DUKE = 5 -- from 4
NDefines.NMilitary.MAX_COMMANDERS_KING = 7 -- from 6
NDefines.NMilitary.MAX_COMMANDERS_EMPEROR = 9 -- from 8

NDefines.NMilitary.FRIENDLY_TERRITORY_LEVY_RETURN_PERCENT = 0.95 -- Reduced from 1.0 to reduce exploiting.
NDefines.NMilitary.OTHER_TERRITORY_LEVY_RETURN_PERCENT = 0.40 -- Reduced from 0.50 (50% loss) to 0.33 (77% loss) to reduce exploiting.

NDefines.NMilitary.BATTLE_TECH_MULTIPLIER = 0.0 -- Removed

NDefines.NMilitary.ATTRITION_LEVEL_FACTOR = 0.5 -- Increased from 0.5
NDefines.NMilitary.ATTRITION_LEVEL_FACTOR_50_OVER = 1.0 -- Increased from 1.0
NDefines.NMilitary.ATTRITION_LEVEL_FACTOR_100_OVER = 2.0 -- Increased from 2.0

NDefines.NMilitary.ARMY_MOVEMENT_SPEED = 3
NDefines.NMilitary.NAVY_MOVEMENT_SPEED = 12 -- Reduced from 15, 4x faster than land movement

NDefines.NMilitary.GALLEYS_MAINTENANCE = 50 -- Reduced from 300

NDefines.NMilitary.LEVY_MAINTENANCE_FACTOR = 1.5

NDefines.NMilitary.LIEGE_LEVY_REINF_RATE = 0.03 -- Reduced for 0.05
NDefines.NMilitary.LIEGE_LEVY_COST_MULTIPLIER = 0.5 -- Halved from 1.0

NDefines.NMilitary.MIN_LEVY_RAISE_OPINION_THRESHOLD = -33 -- Lowered from 0

NDefines.NMilitary.LIGHT_INFANTRY_MORALE = 2
NDefines.NMilitary.LIGHT_INFANTRY_MAINTENANCE = 0.70
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_SKIRMISH_ATTACK = 1
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_MELEE_ATTACK = 3 -- Buffed, formerly 1
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_PURSUE_ATTACK = 3 -- Buffed, formerly 2
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_SKIRMISH_DEFENSE = 2
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_MELEE_DEFENSE = 2 -- Doubled, formerly 1
NDefines.NMilitary.LIGHT_INFANTRY_PHASE_PURSUE_DEFENSE = 2.5

NDefines.NMilitary.HEAVY_INFANTRY_MORALE = 5 -- Buffed, formerly 4
NDefines.NMilitary.HEAVY_INFANTRY_MAINTENANCE = 2 -- Reduced, formerly 3
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_SKIRMISH_ATTACK = 0.25
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_MELEE_ATTACK = 6
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_PURSUE_ATTACK = 1 -- Halfed, formerly 2
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_SKIRMISH_DEFENSE = 5 -- Buffed, formerly 3
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_MELEE_DEFENSE = 4
NDefines.NMilitary.HEAVY_INFANTRY_PHASE_PURSUE_DEFENSE = 2 -- Reduced, formerly 4

NDefines.NMilitary.PIKEMEN_MORALE = 6
NDefines.NMilitary.PIKEMEN_MAINTENANCE = 2
NDefines.NMilitary.PIKEMEN_PHASE_SKIRMISH_ATTACK = 0.1
NDefines.NMilitary.PIKEMEN_PHASE_MELEE_ATTACK = 5
NDefines.NMilitary.PIKEMEN_PHASE_PURSUE_ATTACK = 0.2
NDefines.NMilitary.PIKEMEN_PHASE_SKIRMISH_DEFENSE = 3.5
NDefines.NMilitary.PIKEMEN_PHASE_MELEE_DEFENSE = 8 -- Buffed, formerly 4.5
NDefines.NMilitary.PIKEMEN_PHASE_PURSUE_DEFENSE = 2

NDefines.NMilitary.LIGHT_CAVALRY_MORALE = 4
NDefines.NMilitary.LIGHT_CAVALRY_MAINTENANCE = 2 -- Reduced, formerly 3
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_SKIRMISH_ATTACK = 1.5 -- Nerfed, formerly 2
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_MELEE_ATTACK = 3
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_PURSUE_ATTACK = 10 -- Buffed, formerly 6
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_SKIRMISH_DEFENSE = 4.5
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_MELEE_DEFENSE = 3
NDefines.NMilitary.LIGHT_CAVALRY_PHASE_PURSUE_DEFENSE = 7 -- Doubled, formerly 3.5

NDefines.NMilitary.KNIGHTS_MORALE = 10
NDefines.NMilitary.KNIGHTS_MAINTENANCE = 4 -- Reduced, formerly 6
NDefines.NMilitary.KNIGHTS_PHASE_SKIRMISH_ATTACK = 0.5
NDefines.NMilitary.KNIGHTS_PHASE_MELEE_ATTACK = 10
NDefines.NMilitary.KNIGHTS_PHASE_PURSUE_ATTACK = 6 -- Buffed, formerly 4
NDefines.NMilitary.KNIGHTS_PHASE_SKIRMISH_DEFENSE = 6 -- Buffed, formerly 4
NDefines.NMilitary.KNIGHTS_PHASE_MELEE_DEFENSE = 6 -- Buffed, formerly 5
NDefines.NMilitary.KNIGHTS_PHASE_PURSUE_DEFENSE = 4 -- Reduced, formerly 7.5

NDefines.NMilitary.ARCHERS_MORALE = 1
NDefines.NMilitary.ARCHERS_MAINTENANCE = 1.5 -- Reduced, formerly 2
NDefines.NMilitary.ARCHERS_PHASE_SKIRMISH_ATTACK = 4 -- Doubled, formerly 2
NDefines.NMilitary.ARCHERS_PHASE_MELEE_ATTACK = 1
NDefines.NMilitary.ARCHERS_PHASE_PURSUE_ATTACK = 2
NDefines.NMilitary.ARCHERS_PHASE_SKIRMISH_DEFENSE = 3 -- Doubled, formerly 1.5
NDefines.NMilitary.ARCHERS_PHASE_MELEE_DEFENSE = 1 -- Halved, formerly 2.0
NDefines.NMilitary.ARCHERS_PHASE_PURSUE_DEFENSE = 2.5 -- Buffed, formerly 2.0

-- Technology, removed
NDefines.NTechnology.DONT_EXECUTE_TECH_BEFORE = 6000
NDefines.NTechnology.POINTS_PER_ATTRIBUTE = 0.00
NDefines.NTechnology.BASE_NEIGHBOUR_SPREAD_BONUS = 0.00
NDefines.NTechnology.NEIGHBOUR_SAME_RELIGON_GROUP_MULT = 0.0
NDefines.NTechnology.BASE_DEMESNE_SPREAD_BONUS = 0.00
NDefines.NTechnology.MAX_DEMESNE_BONUS = 0.0
NDefines.NTechnology.TRADEPOST_SPREAD_BONUS = 0.000
NDefines.NTechnology.SPYACTION_SPREAD_BONUS = 0.000
NDefines.NTechnology.IDEAL_YEAR_LEVEL_0 = 6000
NDefines.NTechnology.IDEAL_YEAR_LEVEL_8 = 8900
NDefines.NTechnology.IDEAL_YEAR_AHEAD_PENALTY_INVEST = 0.0
NDefines.NTechnology.BASE_FROM_NOMAD_CAPITAL_SPREAD_BONUS = 0.00
NDefines.NTechnology.BASE_TO_NOMAD_CAPITAL_SPREAD_BONUS = 0.0

-- Graphics
NDefines.NGraphics.CITY_SPRAWL_AMOUNT = 1.4

-- AI
NDefines.NAI.RAID_MAX_REALM_SIZE = 48 -- from 24
NDefines.NAI.RAID_AGGRESSION = 20 -- from 18, slightly fewer raids

-- Ruler Designer
NDefines.NRulerDesigner.MAX_AGE = 70