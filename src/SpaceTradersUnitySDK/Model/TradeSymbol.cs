/*
 * SpaceTraders API
 *
 * SpaceTraders is an open-universe game and learning platform that offers a set of HTTP endpoints to control a fleet of ships and explore a multiplayer universe.  The API is documented using [OpenAPI](https://github.com/SpaceTradersAPI/api-docs). You can send your first request right here in your browser to check the status of the game server.  ```json http {   \"method\": \"GET\",   \"url\": \"https://api.spacetraders.io/v2\", } ```  Unlike a traditional game, SpaceTraders does not have a first-party client or app to play the game. Instead, you can use the API to build your own client, write a script to automate your ships, or try an app built by the community.  We have a [Discord channel](https://discord.com/invite/jh6zurdWk5) where you can share your projects, ask questions, and get help from other players.   
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: joel@spacetraders.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = SpaceTradersUnitySDK.Client.OpenAPIDateConverter;

namespace SpaceTradersUnitySDK.Model
{
    /// <summary>
    /// The good&#39;s symbol.
    /// </summary>
    /// <value>The good&#39;s symbol.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TradeSymbol
    {
        /// <summary>
        /// Enum PRECIOUSSTONES for value: PRECIOUS_STONES
        /// </summary>
        [EnumMember(Value = "PRECIOUS_STONES")]
        PRECIOUSSTONES = 1,

        /// <summary>
        /// Enum QUARTZSAND for value: QUARTZ_SAND
        /// </summary>
        [EnumMember(Value = "QUARTZ_SAND")]
        QUARTZSAND = 2,

        /// <summary>
        /// Enum SILICONCRYSTALS for value: SILICON_CRYSTALS
        /// </summary>
        [EnumMember(Value = "SILICON_CRYSTALS")]
        SILICONCRYSTALS = 3,

        /// <summary>
        /// Enum AMMONIAICE for value: AMMONIA_ICE
        /// </summary>
        [EnumMember(Value = "AMMONIA_ICE")]
        AMMONIAICE = 4,

        /// <summary>
        /// Enum LIQUIDHYDROGEN for value: LIQUID_HYDROGEN
        /// </summary>
        [EnumMember(Value = "LIQUID_HYDROGEN")]
        LIQUIDHYDROGEN = 5,

        /// <summary>
        /// Enum LIQUIDNITROGEN for value: LIQUID_NITROGEN
        /// </summary>
        [EnumMember(Value = "LIQUID_NITROGEN")]
        LIQUIDNITROGEN = 6,

        /// <summary>
        /// Enum ICEWATER for value: ICE_WATER
        /// </summary>
        [EnumMember(Value = "ICE_WATER")]
        ICEWATER = 7,

        /// <summary>
        /// Enum EXOTICMATTER for value: EXOTIC_MATTER
        /// </summary>
        [EnumMember(Value = "EXOTIC_MATTER")]
        EXOTICMATTER = 8,

        /// <summary>
        /// Enum ADVANCEDCIRCUITRY for value: ADVANCED_CIRCUITRY
        /// </summary>
        [EnumMember(Value = "ADVANCED_CIRCUITRY")]
        ADVANCEDCIRCUITRY = 9,

        /// <summary>
        /// Enum GRAVITONEMITTERS for value: GRAVITON_EMITTERS
        /// </summary>
        [EnumMember(Value = "GRAVITON_EMITTERS")]
        GRAVITONEMITTERS = 10,

        /// <summary>
        /// Enum IRON for value: IRON
        /// </summary>
        [EnumMember(Value = "IRON")]
        IRON = 11,

        /// <summary>
        /// Enum IRONORE for value: IRON_ORE
        /// </summary>
        [EnumMember(Value = "IRON_ORE")]
        IRONORE = 12,

        /// <summary>
        /// Enum COPPER for value: COPPER
        /// </summary>
        [EnumMember(Value = "COPPER")]
        COPPER = 13,

        /// <summary>
        /// Enum COPPERORE for value: COPPER_ORE
        /// </summary>
        [EnumMember(Value = "COPPER_ORE")]
        COPPERORE = 14,

        /// <summary>
        /// Enum ALUMINUM for value: ALUMINUM
        /// </summary>
        [EnumMember(Value = "ALUMINUM")]
        ALUMINUM = 15,

        /// <summary>
        /// Enum ALUMINUMORE for value: ALUMINUM_ORE
        /// </summary>
        [EnumMember(Value = "ALUMINUM_ORE")]
        ALUMINUMORE = 16,

        /// <summary>
        /// Enum SILVER for value: SILVER
        /// </summary>
        [EnumMember(Value = "SILVER")]
        SILVER = 17,

        /// <summary>
        /// Enum SILVERORE for value: SILVER_ORE
        /// </summary>
        [EnumMember(Value = "SILVER_ORE")]
        SILVERORE = 18,

        /// <summary>
        /// Enum GOLD for value: GOLD
        /// </summary>
        [EnumMember(Value = "GOLD")]
        GOLD = 19,

        /// <summary>
        /// Enum GOLDORE for value: GOLD_ORE
        /// </summary>
        [EnumMember(Value = "GOLD_ORE")]
        GOLDORE = 20,

        /// <summary>
        /// Enum PLATINUM for value: PLATINUM
        /// </summary>
        [EnumMember(Value = "PLATINUM")]
        PLATINUM = 21,

        /// <summary>
        /// Enum PLATINUMORE for value: PLATINUM_ORE
        /// </summary>
        [EnumMember(Value = "PLATINUM_ORE")]
        PLATINUMORE = 22,

        /// <summary>
        /// Enum DIAMONDS for value: DIAMONDS
        /// </summary>
        [EnumMember(Value = "DIAMONDS")]
        DIAMONDS = 23,

        /// <summary>
        /// Enum URANITE for value: URANITE
        /// </summary>
        [EnumMember(Value = "URANITE")]
        URANITE = 24,

        /// <summary>
        /// Enum URANITEORE for value: URANITE_ORE
        /// </summary>
        [EnumMember(Value = "URANITE_ORE")]
        URANITEORE = 25,

        /// <summary>
        /// Enum MERITIUM for value: MERITIUM
        /// </summary>
        [EnumMember(Value = "MERITIUM")]
        MERITIUM = 26,

        /// <summary>
        /// Enum MERITIUMORE for value: MERITIUM_ORE
        /// </summary>
        [EnumMember(Value = "MERITIUM_ORE")]
        MERITIUMORE = 27,

        /// <summary>
        /// Enum HYDROCARBON for value: HYDROCARBON
        /// </summary>
        [EnumMember(Value = "HYDROCARBON")]
        HYDROCARBON = 28,

        /// <summary>
        /// Enum ANTIMATTER for value: ANTIMATTER
        /// </summary>
        [EnumMember(Value = "ANTIMATTER")]
        ANTIMATTER = 29,

        /// <summary>
        /// Enum FABMATS for value: FAB_MATS
        /// </summary>
        [EnumMember(Value = "FAB_MATS")]
        FABMATS = 30,

        /// <summary>
        /// Enum FERTILIZERS for value: FERTILIZERS
        /// </summary>
        [EnumMember(Value = "FERTILIZERS")]
        FERTILIZERS = 31,

        /// <summary>
        /// Enum FABRICS for value: FABRICS
        /// </summary>
        [EnumMember(Value = "FABRICS")]
        FABRICS = 32,

        /// <summary>
        /// Enum FOOD for value: FOOD
        /// </summary>
        [EnumMember(Value = "FOOD")]
        FOOD = 33,

        /// <summary>
        /// Enum JEWELRY for value: JEWELRY
        /// </summary>
        [EnumMember(Value = "JEWELRY")]
        JEWELRY = 34,

        /// <summary>
        /// Enum MACHINERY for value: MACHINERY
        /// </summary>
        [EnumMember(Value = "MACHINERY")]
        MACHINERY = 35,

        /// <summary>
        /// Enum FIREARMS for value: FIREARMS
        /// </summary>
        [EnumMember(Value = "FIREARMS")]
        FIREARMS = 36,

        /// <summary>
        /// Enum ASSAULTRIFLES for value: ASSAULT_RIFLES
        /// </summary>
        [EnumMember(Value = "ASSAULT_RIFLES")]
        ASSAULTRIFLES = 37,

        /// <summary>
        /// Enum MILITARYEQUIPMENT for value: MILITARY_EQUIPMENT
        /// </summary>
        [EnumMember(Value = "MILITARY_EQUIPMENT")]
        MILITARYEQUIPMENT = 38,

        /// <summary>
        /// Enum EXPLOSIVES for value: EXPLOSIVES
        /// </summary>
        [EnumMember(Value = "EXPLOSIVES")]
        EXPLOSIVES = 39,

        /// <summary>
        /// Enum LABINSTRUMENTS for value: LAB_INSTRUMENTS
        /// </summary>
        [EnumMember(Value = "LAB_INSTRUMENTS")]
        LABINSTRUMENTS = 40,

        /// <summary>
        /// Enum AMMUNITION for value: AMMUNITION
        /// </summary>
        [EnumMember(Value = "AMMUNITION")]
        AMMUNITION = 41,

        /// <summary>
        /// Enum ELECTRONICS for value: ELECTRONICS
        /// </summary>
        [EnumMember(Value = "ELECTRONICS")]
        ELECTRONICS = 42,

        /// <summary>
        /// Enum SHIPPLATING for value: SHIP_PLATING
        /// </summary>
        [EnumMember(Value = "SHIP_PLATING")]
        SHIPPLATING = 43,

        /// <summary>
        /// Enum SHIPPARTS for value: SHIP_PARTS
        /// </summary>
        [EnumMember(Value = "SHIP_PARTS")]
        SHIPPARTS = 44,

        /// <summary>
        /// Enum EQUIPMENT for value: EQUIPMENT
        /// </summary>
        [EnumMember(Value = "EQUIPMENT")]
        EQUIPMENT = 45,

        /// <summary>
        /// Enum FUEL for value: FUEL
        /// </summary>
        [EnumMember(Value = "FUEL")]
        FUEL = 46,

        /// <summary>
        /// Enum MEDICINE for value: MEDICINE
        /// </summary>
        [EnumMember(Value = "MEDICINE")]
        MEDICINE = 47,

        /// <summary>
        /// Enum DRUGS for value: DRUGS
        /// </summary>
        [EnumMember(Value = "DRUGS")]
        DRUGS = 48,

        /// <summary>
        /// Enum CLOTHING for value: CLOTHING
        /// </summary>
        [EnumMember(Value = "CLOTHING")]
        CLOTHING = 49,

        /// <summary>
        /// Enum MICROPROCESSORS for value: MICROPROCESSORS
        /// </summary>
        [EnumMember(Value = "MICROPROCESSORS")]
        MICROPROCESSORS = 50,

        /// <summary>
        /// Enum PLASTICS for value: PLASTICS
        /// </summary>
        [EnumMember(Value = "PLASTICS")]
        PLASTICS = 51,

        /// <summary>
        /// Enum POLYNUCLEOTIDES for value: POLYNUCLEOTIDES
        /// </summary>
        [EnumMember(Value = "POLYNUCLEOTIDES")]
        POLYNUCLEOTIDES = 52,

        /// <summary>
        /// Enum BIOCOMPOSITES for value: BIOCOMPOSITES
        /// </summary>
        [EnumMember(Value = "BIOCOMPOSITES")]
        BIOCOMPOSITES = 53,

        /// <summary>
        /// Enum QUANTUMSTABILIZERS for value: QUANTUM_STABILIZERS
        /// </summary>
        [EnumMember(Value = "QUANTUM_STABILIZERS")]
        QUANTUMSTABILIZERS = 54,

        /// <summary>
        /// Enum NANOBOTS for value: NANOBOTS
        /// </summary>
        [EnumMember(Value = "NANOBOTS")]
        NANOBOTS = 55,

        /// <summary>
        /// Enum AIMAINFRAMES for value: AI_MAINFRAMES
        /// </summary>
        [EnumMember(Value = "AI_MAINFRAMES")]
        AIMAINFRAMES = 56,

        /// <summary>
        /// Enum QUANTUMDRIVES for value: QUANTUM_DRIVES
        /// </summary>
        [EnumMember(Value = "QUANTUM_DRIVES")]
        QUANTUMDRIVES = 57,

        /// <summary>
        /// Enum ROBOTICDRONES for value: ROBOTIC_DRONES
        /// </summary>
        [EnumMember(Value = "ROBOTIC_DRONES")]
        ROBOTICDRONES = 58,

        /// <summary>
        /// Enum CYBERIMPLANTS for value: CYBER_IMPLANTS
        /// </summary>
        [EnumMember(Value = "CYBER_IMPLANTS")]
        CYBERIMPLANTS = 59,

        /// <summary>
        /// Enum GENETHERAPEUTICS for value: GENE_THERAPEUTICS
        /// </summary>
        [EnumMember(Value = "GENE_THERAPEUTICS")]
        GENETHERAPEUTICS = 60,

        /// <summary>
        /// Enum NEURALCHIPS for value: NEURAL_CHIPS
        /// </summary>
        [EnumMember(Value = "NEURAL_CHIPS")]
        NEURALCHIPS = 61,

        /// <summary>
        /// Enum MOODREGULATORS for value: MOOD_REGULATORS
        /// </summary>
        [EnumMember(Value = "MOOD_REGULATORS")]
        MOODREGULATORS = 62,

        /// <summary>
        /// Enum VIRALAGENTS for value: VIRAL_AGENTS
        /// </summary>
        [EnumMember(Value = "VIRAL_AGENTS")]
        VIRALAGENTS = 63,

        /// <summary>
        /// Enum MICROFUSIONGENERATORS for value: MICRO_FUSION_GENERATORS
        /// </summary>
        [EnumMember(Value = "MICRO_FUSION_GENERATORS")]
        MICROFUSIONGENERATORS = 64,

        /// <summary>
        /// Enum SUPERGRAINS for value: SUPERGRAINS
        /// </summary>
        [EnumMember(Value = "SUPERGRAINS")]
        SUPERGRAINS = 65,

        /// <summary>
        /// Enum LASERRIFLES for value: LASER_RIFLES
        /// </summary>
        [EnumMember(Value = "LASER_RIFLES")]
        LASERRIFLES = 66,

        /// <summary>
        /// Enum HOLOGRAPHICS for value: HOLOGRAPHICS
        /// </summary>
        [EnumMember(Value = "HOLOGRAPHICS")]
        HOLOGRAPHICS = 67,

        /// <summary>
        /// Enum SHIPSALVAGE for value: SHIP_SALVAGE
        /// </summary>
        [EnumMember(Value = "SHIP_SALVAGE")]
        SHIPSALVAGE = 68,

        /// <summary>
        /// Enum RELICTECH for value: RELIC_TECH
        /// </summary>
        [EnumMember(Value = "RELIC_TECH")]
        RELICTECH = 69,

        /// <summary>
        /// Enum NOVELLIFEFORMS for value: NOVEL_LIFEFORMS
        /// </summary>
        [EnumMember(Value = "NOVEL_LIFEFORMS")]
        NOVELLIFEFORMS = 70,

        /// <summary>
        /// Enum BOTANICALSPECIMENS for value: BOTANICAL_SPECIMENS
        /// </summary>
        [EnumMember(Value = "BOTANICAL_SPECIMENS")]
        BOTANICALSPECIMENS = 71,

        /// <summary>
        /// Enum CULTURALARTIFACTS for value: CULTURAL_ARTIFACTS
        /// </summary>
        [EnumMember(Value = "CULTURAL_ARTIFACTS")]
        CULTURALARTIFACTS = 72,

        /// <summary>
        /// Enum FRAMEPROBE for value: FRAME_PROBE
        /// </summary>
        [EnumMember(Value = "FRAME_PROBE")]
        FRAMEPROBE = 73,

        /// <summary>
        /// Enum FRAMEDRONE for value: FRAME_DRONE
        /// </summary>
        [EnumMember(Value = "FRAME_DRONE")]
        FRAMEDRONE = 74,

        /// <summary>
        /// Enum FRAMEINTERCEPTOR for value: FRAME_INTERCEPTOR
        /// </summary>
        [EnumMember(Value = "FRAME_INTERCEPTOR")]
        FRAMEINTERCEPTOR = 75,

        /// <summary>
        /// Enum FRAMERACER for value: FRAME_RACER
        /// </summary>
        [EnumMember(Value = "FRAME_RACER")]
        FRAMERACER = 76,

        /// <summary>
        /// Enum FRAMEFIGHTER for value: FRAME_FIGHTER
        /// </summary>
        [EnumMember(Value = "FRAME_FIGHTER")]
        FRAMEFIGHTER = 77,

        /// <summary>
        /// Enum FRAMEFRIGATE for value: FRAME_FRIGATE
        /// </summary>
        [EnumMember(Value = "FRAME_FRIGATE")]
        FRAMEFRIGATE = 78,

        /// <summary>
        /// Enum FRAMESHUTTLE for value: FRAME_SHUTTLE
        /// </summary>
        [EnumMember(Value = "FRAME_SHUTTLE")]
        FRAMESHUTTLE = 79,

        /// <summary>
        /// Enum FRAMEEXPLORER for value: FRAME_EXPLORER
        /// </summary>
        [EnumMember(Value = "FRAME_EXPLORER")]
        FRAMEEXPLORER = 80,

        /// <summary>
        /// Enum FRAMEMINER for value: FRAME_MINER
        /// </summary>
        [EnumMember(Value = "FRAME_MINER")]
        FRAMEMINER = 81,

        /// <summary>
        /// Enum FRAMELIGHTFREIGHTER for value: FRAME_LIGHT_FREIGHTER
        /// </summary>
        [EnumMember(Value = "FRAME_LIGHT_FREIGHTER")]
        FRAMELIGHTFREIGHTER = 82,

        /// <summary>
        /// Enum FRAMEHEAVYFREIGHTER for value: FRAME_HEAVY_FREIGHTER
        /// </summary>
        [EnumMember(Value = "FRAME_HEAVY_FREIGHTER")]
        FRAMEHEAVYFREIGHTER = 83,

        /// <summary>
        /// Enum FRAMETRANSPORT for value: FRAME_TRANSPORT
        /// </summary>
        [EnumMember(Value = "FRAME_TRANSPORT")]
        FRAMETRANSPORT = 84,

        /// <summary>
        /// Enum FRAMEDESTROYER for value: FRAME_DESTROYER
        /// </summary>
        [EnumMember(Value = "FRAME_DESTROYER")]
        FRAMEDESTROYER = 85,

        /// <summary>
        /// Enum FRAMECRUISER for value: FRAME_CRUISER
        /// </summary>
        [EnumMember(Value = "FRAME_CRUISER")]
        FRAMECRUISER = 86,

        /// <summary>
        /// Enum FRAMECARRIER for value: FRAME_CARRIER
        /// </summary>
        [EnumMember(Value = "FRAME_CARRIER")]
        FRAMECARRIER = 87,

        /// <summary>
        /// Enum REACTORSOLARI for value: REACTOR_SOLAR_I
        /// </summary>
        [EnumMember(Value = "REACTOR_SOLAR_I")]
        REACTORSOLARI = 88,

        /// <summary>
        /// Enum REACTORFUSIONI for value: REACTOR_FUSION_I
        /// </summary>
        [EnumMember(Value = "REACTOR_FUSION_I")]
        REACTORFUSIONI = 89,

        /// <summary>
        /// Enum REACTORFISSIONI for value: REACTOR_FISSION_I
        /// </summary>
        [EnumMember(Value = "REACTOR_FISSION_I")]
        REACTORFISSIONI = 90,

        /// <summary>
        /// Enum REACTORCHEMICALI for value: REACTOR_CHEMICAL_I
        /// </summary>
        [EnumMember(Value = "REACTOR_CHEMICAL_I")]
        REACTORCHEMICALI = 91,

        /// <summary>
        /// Enum REACTORANTIMATTERI for value: REACTOR_ANTIMATTER_I
        /// </summary>
        [EnumMember(Value = "REACTOR_ANTIMATTER_I")]
        REACTORANTIMATTERI = 92,

        /// <summary>
        /// Enum ENGINEIMPULSEDRIVEI for value: ENGINE_IMPULSE_DRIVE_I
        /// </summary>
        [EnumMember(Value = "ENGINE_IMPULSE_DRIVE_I")]
        ENGINEIMPULSEDRIVEI = 93,

        /// <summary>
        /// Enum ENGINEIONDRIVEI for value: ENGINE_ION_DRIVE_I
        /// </summary>
        [EnumMember(Value = "ENGINE_ION_DRIVE_I")]
        ENGINEIONDRIVEI = 94,

        /// <summary>
        /// Enum ENGINEIONDRIVEII for value: ENGINE_ION_DRIVE_II
        /// </summary>
        [EnumMember(Value = "ENGINE_ION_DRIVE_II")]
        ENGINEIONDRIVEII = 95,

        /// <summary>
        /// Enum ENGINEHYPERDRIVEI for value: ENGINE_HYPER_DRIVE_I
        /// </summary>
        [EnumMember(Value = "ENGINE_HYPER_DRIVE_I")]
        ENGINEHYPERDRIVEI = 96,

        /// <summary>
        /// Enum MODULEMINERALPROCESSORI for value: MODULE_MINERAL_PROCESSOR_I
        /// </summary>
        [EnumMember(Value = "MODULE_MINERAL_PROCESSOR_I")]
        MODULEMINERALPROCESSORI = 97,

        /// <summary>
        /// Enum MODULEGASPROCESSORI for value: MODULE_GAS_PROCESSOR_I
        /// </summary>
        [EnumMember(Value = "MODULE_GAS_PROCESSOR_I")]
        MODULEGASPROCESSORI = 98,

        /// <summary>
        /// Enum MODULECARGOHOLDI for value: MODULE_CARGO_HOLD_I
        /// </summary>
        [EnumMember(Value = "MODULE_CARGO_HOLD_I")]
        MODULECARGOHOLDI = 99,

        /// <summary>
        /// Enum MODULECARGOHOLDII for value: MODULE_CARGO_HOLD_II
        /// </summary>
        [EnumMember(Value = "MODULE_CARGO_HOLD_II")]
        MODULECARGOHOLDII = 100,

        /// <summary>
        /// Enum MODULECARGOHOLDIII for value: MODULE_CARGO_HOLD_III
        /// </summary>
        [EnumMember(Value = "MODULE_CARGO_HOLD_III")]
        MODULECARGOHOLDIII = 101,

        /// <summary>
        /// Enum MODULECREWQUARTERSI for value: MODULE_CREW_QUARTERS_I
        /// </summary>
        [EnumMember(Value = "MODULE_CREW_QUARTERS_I")]
        MODULECREWQUARTERSI = 102,

        /// <summary>
        /// Enum MODULEENVOYQUARTERSI for value: MODULE_ENVOY_QUARTERS_I
        /// </summary>
        [EnumMember(Value = "MODULE_ENVOY_QUARTERS_I")]
        MODULEENVOYQUARTERSI = 103,

        /// <summary>
        /// Enum MODULEPASSENGERCABINI for value: MODULE_PASSENGER_CABIN_I
        /// </summary>
        [EnumMember(Value = "MODULE_PASSENGER_CABIN_I")]
        MODULEPASSENGERCABINI = 104,

        /// <summary>
        /// Enum MODULEMICROREFINERYI for value: MODULE_MICRO_REFINERY_I
        /// </summary>
        [EnumMember(Value = "MODULE_MICRO_REFINERY_I")]
        MODULEMICROREFINERYI = 105,

        /// <summary>
        /// Enum MODULESCIENCELABI for value: MODULE_SCIENCE_LAB_I
        /// </summary>
        [EnumMember(Value = "MODULE_SCIENCE_LAB_I")]
        MODULESCIENCELABI = 106,

        /// <summary>
        /// Enum MODULEJUMPDRIVEI for value: MODULE_JUMP_DRIVE_I
        /// </summary>
        [EnumMember(Value = "MODULE_JUMP_DRIVE_I")]
        MODULEJUMPDRIVEI = 107,

        /// <summary>
        /// Enum MODULEJUMPDRIVEII for value: MODULE_JUMP_DRIVE_II
        /// </summary>
        [EnumMember(Value = "MODULE_JUMP_DRIVE_II")]
        MODULEJUMPDRIVEII = 108,

        /// <summary>
        /// Enum MODULEJUMPDRIVEIII for value: MODULE_JUMP_DRIVE_III
        /// </summary>
        [EnumMember(Value = "MODULE_JUMP_DRIVE_III")]
        MODULEJUMPDRIVEIII = 109,

        /// <summary>
        /// Enum MODULEWARPDRIVEI for value: MODULE_WARP_DRIVE_I
        /// </summary>
        [EnumMember(Value = "MODULE_WARP_DRIVE_I")]
        MODULEWARPDRIVEI = 110,

        /// <summary>
        /// Enum MODULEWARPDRIVEII for value: MODULE_WARP_DRIVE_II
        /// </summary>
        [EnumMember(Value = "MODULE_WARP_DRIVE_II")]
        MODULEWARPDRIVEII = 111,

        /// <summary>
        /// Enum MODULEWARPDRIVEIII for value: MODULE_WARP_DRIVE_III
        /// </summary>
        [EnumMember(Value = "MODULE_WARP_DRIVE_III")]
        MODULEWARPDRIVEIII = 112,

        /// <summary>
        /// Enum MODULESHIELDGENERATORI for value: MODULE_SHIELD_GENERATOR_I
        /// </summary>
        [EnumMember(Value = "MODULE_SHIELD_GENERATOR_I")]
        MODULESHIELDGENERATORI = 113,

        /// <summary>
        /// Enum MODULESHIELDGENERATORII for value: MODULE_SHIELD_GENERATOR_II
        /// </summary>
        [EnumMember(Value = "MODULE_SHIELD_GENERATOR_II")]
        MODULESHIELDGENERATORII = 114,

        /// <summary>
        /// Enum MODULEOREREFINERYI for value: MODULE_ORE_REFINERY_I
        /// </summary>
        [EnumMember(Value = "MODULE_ORE_REFINERY_I")]
        MODULEOREREFINERYI = 115,

        /// <summary>
        /// Enum MODULEFUELREFINERYI for value: MODULE_FUEL_REFINERY_I
        /// </summary>
        [EnumMember(Value = "MODULE_FUEL_REFINERY_I")]
        MODULEFUELREFINERYI = 116,

        /// <summary>
        /// Enum MOUNTGASSIPHONI for value: MOUNT_GAS_SIPHON_I
        /// </summary>
        [EnumMember(Value = "MOUNT_GAS_SIPHON_I")]
        MOUNTGASSIPHONI = 117,

        /// <summary>
        /// Enum MOUNTGASSIPHONII for value: MOUNT_GAS_SIPHON_II
        /// </summary>
        [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
        MOUNTGASSIPHONII = 118,

        /// <summary>
        /// Enum MOUNTGASSIPHONIII for value: MOUNT_GAS_SIPHON_III
        /// </summary>
        [EnumMember(Value = "MOUNT_GAS_SIPHON_III")]
        MOUNTGASSIPHONIII = 119,

        /// <summary>
        /// Enum MOUNTSURVEYORI for value: MOUNT_SURVEYOR_I
        /// </summary>
        [EnumMember(Value = "MOUNT_SURVEYOR_I")]
        MOUNTSURVEYORI = 120,

        /// <summary>
        /// Enum MOUNTSURVEYORII for value: MOUNT_SURVEYOR_II
        /// </summary>
        [EnumMember(Value = "MOUNT_SURVEYOR_II")]
        MOUNTSURVEYORII = 121,

        /// <summary>
        /// Enum MOUNTSURVEYORIII for value: MOUNT_SURVEYOR_III
        /// </summary>
        [EnumMember(Value = "MOUNT_SURVEYOR_III")]
        MOUNTSURVEYORIII = 122,

        /// <summary>
        /// Enum MOUNTSENSORARRAYI for value: MOUNT_SENSOR_ARRAY_I
        /// </summary>
        [EnumMember(Value = "MOUNT_SENSOR_ARRAY_I")]
        MOUNTSENSORARRAYI = 123,

        /// <summary>
        /// Enum MOUNTSENSORARRAYII for value: MOUNT_SENSOR_ARRAY_II
        /// </summary>
        [EnumMember(Value = "MOUNT_SENSOR_ARRAY_II")]
        MOUNTSENSORARRAYII = 124,

        /// <summary>
        /// Enum MOUNTSENSORARRAYIII for value: MOUNT_SENSOR_ARRAY_III
        /// </summary>
        [EnumMember(Value = "MOUNT_SENSOR_ARRAY_III")]
        MOUNTSENSORARRAYIII = 125,

        /// <summary>
        /// Enum MOUNTMININGLASERI for value: MOUNT_MINING_LASER_I
        /// </summary>
        [EnumMember(Value = "MOUNT_MINING_LASER_I")]
        MOUNTMININGLASERI = 126,

        /// <summary>
        /// Enum MOUNTMININGLASERII for value: MOUNT_MINING_LASER_II
        /// </summary>
        [EnumMember(Value = "MOUNT_MINING_LASER_II")]
        MOUNTMININGLASERII = 127,

        /// <summary>
        /// Enum MOUNTMININGLASERIII for value: MOUNT_MINING_LASER_III
        /// </summary>
        [EnumMember(Value = "MOUNT_MINING_LASER_III")]
        MOUNTMININGLASERIII = 128,

        /// <summary>
        /// Enum MOUNTLASERCANNONI for value: MOUNT_LASER_CANNON_I
        /// </summary>
        [EnumMember(Value = "MOUNT_LASER_CANNON_I")]
        MOUNTLASERCANNONI = 129,

        /// <summary>
        /// Enum MOUNTMISSILELAUNCHERI for value: MOUNT_MISSILE_LAUNCHER_I
        /// </summary>
        [EnumMember(Value = "MOUNT_MISSILE_LAUNCHER_I")]
        MOUNTMISSILELAUNCHERI = 130,

        /// <summary>
        /// Enum MOUNTTURRETI for value: MOUNT_TURRET_I
        /// </summary>
        [EnumMember(Value = "MOUNT_TURRET_I")]
        MOUNTTURRETI = 131,

        /// <summary>
        /// Enum SHIPPROBE for value: SHIP_PROBE
        /// </summary>
        [EnumMember(Value = "SHIP_PROBE")]
        SHIPPROBE = 132,

        /// <summary>
        /// Enum SHIPMININGDRONE for value: SHIP_MINING_DRONE
        /// </summary>
        [EnumMember(Value = "SHIP_MINING_DRONE")]
        SHIPMININGDRONE = 133,

        /// <summary>
        /// Enum SHIPSIPHONDRONE for value: SHIP_SIPHON_DRONE
        /// </summary>
        [EnumMember(Value = "SHIP_SIPHON_DRONE")]
        SHIPSIPHONDRONE = 134,

        /// <summary>
        /// Enum SHIPINTERCEPTOR for value: SHIP_INTERCEPTOR
        /// </summary>
        [EnumMember(Value = "SHIP_INTERCEPTOR")]
        SHIPINTERCEPTOR = 135,

        /// <summary>
        /// Enum SHIPLIGHTHAULER for value: SHIP_LIGHT_HAULER
        /// </summary>
        [EnumMember(Value = "SHIP_LIGHT_HAULER")]
        SHIPLIGHTHAULER = 136,

        /// <summary>
        /// Enum SHIPCOMMANDFRIGATE for value: SHIP_COMMAND_FRIGATE
        /// </summary>
        [EnumMember(Value = "SHIP_COMMAND_FRIGATE")]
        SHIPCOMMANDFRIGATE = 137,

        /// <summary>
        /// Enum SHIPEXPLORER for value: SHIP_EXPLORER
        /// </summary>
        [EnumMember(Value = "SHIP_EXPLORER")]
        SHIPEXPLORER = 138,

        /// <summary>
        /// Enum SHIPHEAVYFREIGHTER for value: SHIP_HEAVY_FREIGHTER
        /// </summary>
        [EnumMember(Value = "SHIP_HEAVY_FREIGHTER")]
        SHIPHEAVYFREIGHTER = 139,

        /// <summary>
        /// Enum SHIPLIGHTSHUTTLE for value: SHIP_LIGHT_SHUTTLE
        /// </summary>
        [EnumMember(Value = "SHIP_LIGHT_SHUTTLE")]
        SHIPLIGHTSHUTTLE = 140,

        /// <summary>
        /// Enum SHIPOREHOUND for value: SHIP_ORE_HOUND
        /// </summary>
        [EnumMember(Value = "SHIP_ORE_HOUND")]
        SHIPOREHOUND = 141,

        /// <summary>
        /// Enum SHIPREFININGFREIGHTER for value: SHIP_REFINING_FREIGHTER
        /// </summary>
        [EnumMember(Value = "SHIP_REFINING_FREIGHTER")]
        SHIPREFININGFREIGHTER = 142,

        /// <summary>
        /// Enum SHIPSURVEYOR for value: SHIP_SURVEYOR
        /// </summary>
        [EnumMember(Value = "SHIP_SURVEYOR")]
        SHIPSURVEYOR = 143

    }

}
