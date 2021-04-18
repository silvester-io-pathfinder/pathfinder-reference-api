﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class TraitSeeder : IEntitySeeder<Trait>
    {
        public IEnumerable<Trait> GetSeedEntities()
        {
            //Elemental Traits
            yield return new Trait { Id = Guid.Parse("7cb74b87-4e13-4d8c-afa5-da8cbe671bfc"), Name = "Air", Description = "Effects with the air trait either manipulate or conjure air. Those that manipulate air have no effect in a vacuum or an area without air. Creatures with this trait consist primarily of air or have a magical connection to that element. Planes with this trait consist mostly of open spaces and air with various degrees of turbulence, though they also contain rare islands of floating stone and other elements and energies." };
            yield return new Trait { Id = Guid.Parse("ae21e02b-11a1-4c53-96ec-5961beb2761d"), Name = "Water", Description = "Effects with the water trait either manipulate or conjure water. Those that manipulate water have no effect in an area without water. Creatures with this trait consist primarily of water or have a magical connection to the element. Planes with this trait are mostly liquid, perhaps with pockets of breathable air." };
            yield return new Trait { Id = Guid.Parse("d1aabc8c-b3fe-40eb-bfc2-ea72d3b7e0c0"), Name = "Fire", Description = "Effects with the fire trait deal fire damage or either conjure or manipulate fire. Those that manipulate fire have no effect in an area without fire. Creatures with this trait consist primarily of fire or have a magical connection to that element. Planes with this trait are composed of flames that continually burn with no fuel source. Fire planes are extremely hostile to non-fire creatures." };
            yield return new Trait { Id = Guid.Parse("689bc25d-de13-418c-8da2-a9280936359d"), Name = "Earth", Description = "Effects with the earth trait either manipulate or conjure earth. Those that manipulate earth have no effect in an area without earth. Creatures with this trait consist primarily of earth or have a magical connection to that element. Planes with this trait are mostly solid, with caverns and other hollow pockets." };

            //Energy Traits
            yield return new Trait { Id = Guid.Parse("44a15dce-b0cf-4d6a-a4be-92d759fdbaa3"), Name = "Acid", Description = "Effects with this trait deal acid damage. Creatures with this trait have a magical connection to acid." };
            yield return new Trait { Id = Guid.Parse("36d65d85-b689-46da-86b6-4f0838f296e6"), Name = "Cold", Description = "Effects with this trait deal cold damage. Creatures with this trait have a connection to magical cold." };
            yield return new Trait { Id = Guid.Parse("dc6ca4d1-85f2-4be9-bc39-9a48b943b392"), Name = "Electricity", Description = "Effects with this trait deal electricity damage. A creature with this trait has a magical connection to electricity." };
            yield return new Trait { Id = Guid.Parse("e55f102e-414e-4210-b1b3-97d8c26bab6a"), Name = "Force", Description = "Effects with this trait deal force damage or create objects made of pure magical force." };
            yield return new Trait { Id = Guid.Parse("30ed464b-6bf4-4a80-8c42-8bb95ecb751c"), Name = "Negative", Description = "Effects with this trait heal undead creatures with negative energy, deal negative damage to living creatures, or manipulate negative energy. Planes with this trait are vast, empty reaches that suck the life from the living. Creatures with this trait are natives of the Negative Energy Plane. They can survive the basic environmental effects of the Negative Energy Plane." };
            yield return new Trait { Id = Guid.Parse("ece55c2d-2715-4e67-aa1e-736c019e89a6"), Name = "Positive", Description = "Effects with this trait heal living creatures with positive energy, deal positive energy damage to undead, or manipulate positive energy. Planes with this trait are awash with life energy of such intensity that it can harm living creatures. Creatures with this trait are natives of the Positive Energy Plane. They can survive the basic environmental effects of the Positive Energy Plane." };
            yield return new Trait { Id = Guid.Parse("812b4b93-b467-438f-9561-ef020545755f"), Name = "Sonic", Description = "An effect with the sonic trait functions only if it makes sound, meaning it has no effect in an area of silence or in a vacuum. This is different from an auditory spell, which is effective only if the target can hear it. A sonic effect might deal sonic damage. A creature with this trait has a magical connection to powerful sound." };

            //Tradition Traits
            yield return new Trait { Id = Guid.Parse("a0e52203-1c57-4a58-bff2-7e262b56181f"), Name = "Arcane", Description = "This magic comes from the arcane tradition, which is built on logic and rationality. Anything with this trait is magical." };
            yield return new Trait { Id = Guid.Parse("561c7c89-44d2-492e-b12f-352af45b6a6b"), Name = "Divine", Description = "This magic comes from the divine tradition, drawing power from deities or similar sources. Anything with this trait is magical." };
            yield return new Trait { Id = Guid.Parse("0e3307ce-952d-4d93-bcac-95bbf495ee85"), Name = "Occult", Description = "This magic comes from the occult tradition, calling upon bizarre and ephemeral mysteries. Anything with this trait is magical." };
            yield return new Trait { Id = Guid.Parse("3de4876d-2336-4d5e-bbbb-5b4e83ea6d49"), Name = "Primal", Description = "This magic comes from the primal tradition, connecting to the natural world and instinct. Anything with this trait is magical." };

            //Rarity Traits
            yield return new Trait { Id = Guid.Parse("5b33384c-0c98-4238-8257-8b911933308e"), Name = "Common", Description = "Anything that doesn't list another rarity trait (uncommon, rare, or unique) automatically has the common trait. This rarity indicates that an ability, item, or spell is available to all players who meet the prerequisites for it. A creature of this rarity is generally known and can be summoned with the appropriate summon spell." };
            yield return new Trait { Id = Guid.Parse("0c06a5b8-24e7-486b-bb98-91caef377013"), Name = "Uncommon", Description = "Something of uncommon rarity requires special training or comes from a particular culture or part of the world. Some character choices give access to uncommon options, and the GM can choose to allow access for anyone. Less is known about uncommon creatures than common creatures. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creature is increased by 2." };
            yield return new Trait { Id = Guid.Parse("f2810f2b-6f8a-4fb1-b00f-a9d307f97eff"), Name = "Rare", Description = "This rarity indicates that a rules element is very difficult to find in the game world. A rare feat, spell, item or the like is available to players only if the GM decides to include it in the game, typically through discovery during play. Creatures with this trait are rare. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creatures is increased by 5." };
            yield return new Trait { Id = Guid.Parse("68d3b3ab-d2ed-4691-8609-7403c843c77f"), Name = "Unique", Description = "A rules element with this trait is one-of-a-kind. The DC of Recall Knowledge checks related to creatures with this trait is increased by 10." };

            //School Traits
            yield return new Trait { Id = Guid.Parse("c499214b-94fc-4103-8c7c-6f7a56b5c980"), Name = "Abjuration", Description = "Effects and magic items with this trait are associated with the abjuration school of magic, typically involving protection or wards." };
            yield return new Trait { Id = Guid.Parse("6f187720-6664-44c6-8e09-2053ed1054d6"), Name = "Conjuration", Description = "Effects and magic items with this trait are associated with the conjuration school of magic, typically involving summoning, creation, teleportation, or moving things from place to place." };
            yield return new Trait { Id = Guid.Parse("5bce1594-6c07-460f-b306-0db1fa30833b"), Name = "Divination", Description = "The divination school of magic typically involves obtaining or transferring information, or predicting events." };
            yield return new Trait { Id = Guid.Parse("e7fd1927-8c01-4945-899e-a99d2e44662a"), Name = "Enchantment", Description = "Effects and magic items with this trait are associated with the enchantment school of magic, typically involving mind control, emotion alteration, and other mental effects." };
            yield return new Trait { Id = Guid.Parse("f5f7ca8a-100a-4d93-aa07-e0f1bb3cbc49"), Name = "Evocation", Description = "Effects and magic items with this trait are associated with the evocation school of magic, typically involving energy and elemental forces." };
            yield return new Trait { Id = Guid.Parse("7f9fe1cb-c607-44c3-8f1a-b26d508cfce6"), Name = "Illusion", Description = "Effects and magic items with this trait are associated with the illusion school of magic, typically involving false sensory stimuli." };
            yield return new Trait { Id = Guid.Parse("2d643d25-b9aa-4544-b482-04b3475eb82b"), Name = "Necromancy", Description = "Effects and magic items with this trait are associated with the necromancy school of magic, typically involving forces of life and death." };
            yield return new Trait { Id = Guid.Parse("d751d93f-cff9-448f-8ab0-9a3c07eacbef"), Name = "Transmutation", Description = "Effects and magic items with this trait are associated with the transmutation school of magic, typically changing something’s form." };

            //Sense Traits
            yield return new Trait { Id = Guid.Parse("44a18bec-0799-41a7-9b07-16113bb0623f"), Name = "Auditory", Description = "Auditory actions and effects rely on sound. An action with the auditory trait can be successfully performed only if the creature using the action can speak or otherwise produce the required sounds. A spell or effect with the auditory trait has its effect only if the target can hear it. This applies only to sound-based parts of the effect, as determined by the GM. This is different from a sonic effect, which still affects targets who can't hear it (such as deaf targets) as long as the effect itself makes sound." };
            yield return new Trait { Id = Guid.Parse("a6217da0-ad2a-43a0-88d4-ac85f1d68591"), Name = "Olfactory", Description = "An olfactory effect can affect only creatures that can smell it. This applies only to olfactory parts of the effect, as determined by the GM." };
            yield return new Trait { Id = Guid.Parse("e2bb08cb-cf59-4e29-8738-52c751405fb0"), Name = "Visual", Description = "A visual effect can affect only creatures that can see it. This applies only to visible parts of the effect, as determined by the GM." };
            yield return new Trait { Id = Guid.Parse("d748ac0d-6af3-4475-af4e-a72455960fe0"), Name = "Verbal", Description = "A verbal component is a vocalization of words of power. You must speak them in a strong voice, so it’s hard to conceal that you’re Casting a Spell. The spell gains the concentrate trait. You must be able to speak to provide this component." };

            //Poison Traits
            yield return new Trait { Id = Guid.Parse("0b49fe13-7684-43b9-b5a5-81b8c038dc9c"), Name = "Contact", Description = "This poison is delivered by contact with the skin." };
            yield return new Trait { Id = Guid.Parse("3078e40b-db78-4f39-9ffc-304e6a1993cf"), Name = "Ingested", Description = "This poison is delivered when drunk or eaten." };
            yield return new Trait { Id = Guid.Parse("551070c6-e73a-4c0c-9a9c-f6425f38f5f0"), Name = "Inhaled", Description = "This poison is delivered when breathed in." };
            yield return new Trait { Id = Guid.Parse("574e4077-83a5-4865-95a3-29a556f873ed"), Name = "Injury", Description = "This poison is delivered by damaging the recipient." };
            yield return new Trait { Id = Guid.Parse("39e2298b-bab0-49b7-8a0a-4ac1145611b0"), Name = "Poison", Description = "An effect with this trait delivers a poison or deals poison damage. An item with this trait is poisonous and might cause an affliction." };

            //Light Traits
            yield return new Trait { Id = Guid.Parse("aa2b017d-2e8c-460a-9069-6bf61b69dd72"), Name = "Darkness", Description = "Darkness effects extinguish non-magical light in the area, and can counteract less powerful magical light. You must usually target light magic with your darkness magic directly to counteract the light, but some darkness spells automatically attempt to counteract light." };
            yield return new Trait { Id = Guid.Parse("c90d2554-1af6-45d7-9f20-f98aa0799887"), Name = "Light", Description = "Light effects overcome non-magical darkness in the area, and can counteract magical darkness. You must usually target darkness magic with your light magic directly to counteract the darkness, but some light spells automatically attempt to counteract darkness." };

            //Weapon Traits
            yield return new Trait { Id = Guid.Parse("23655aa4-871f-416f-be14-1fc03bedef16"), Name = "Nonlethal", Description = "An effect with this trait is not inherently deadly. Damage from a nonlethal effect knocks a creature out rather than killing it. You can use a nonlethal weapon to make a lethal attack with a –2 circumstance penalty." };

            //Feat Traits
            yield return new Trait { Id = Guid.Parse("3d4c67f6-d5a1-4529-9559-02aa18d81054"), Name = "General", Description = "A type of feat that any character can select, regardless of ancestry and class, as long as they meet the prerequisites. You can select a feat with this trait when your class grants a general feat." };
            yield return new Trait { Id = Guid.Parse("4fbbdfad-330f-4e0f-92dd-d070a59d7498"), Name = "Skill", Description = "A general feat with the skill trait improves your skills and their actions or gives you new actions for a skill. A feat with this trait can be selected when a class grants a skill feat or general feat. Archetype feats with the skill trait can be selected in place of a skill feat if you have that archetype’s dedication feat." };

            //Action Traits
            yield return new Trait { Id = Guid.Parse("08bac763-e881-4a70-b253-916191ee9713"), Name = "Move", Description = "An action with this trait involves moving from one space to another." };
            yield return new Trait { Id = Guid.Parse("c5e1a5e7-5d45-4826-b2ea-018b361770de"), Name = "Concentrate", Description = "An action with this trait requires a degree of mental concentration and discipline." };
            yield return new Trait { Id = Guid.Parse("5f7b92e7-09d2-4717-8588-56b45c08a111"), Name = "Secret", Description = "The GM rolls the check for this ability in secret." };

            //Other
            yield return new Trait { Id = Guid.Parse("856db08f-edad-472b-b870-65a8f16252a5"), Name = "Attack", Description = "An ability with this trait involves an attack. For each attack you make beyond the first on your turn, you take a multiple attack penalty." };
            yield return new Trait { Id = Guid.Parse("9da1e40e-f9b8-4381-9167-229fee66f4f7"), Name = "Cantrip", Description = "A spell you can cast at will that is automatically heightened to half your level rounded up." };
            yield return new Trait { Id = Guid.Parse("e5b98ff4-8503-461c-870d-7b8c8e4811fa"), Name = "Chaotic", Description = "Chaotic effects often manipulate energy from chaos-aligned Outer Planes and are anathema to lawful divine servants or divine servants of lawful deities." };
            yield return new Trait { Id = Guid.Parse("f1f5c47a-fec2-4983-8229-3c4e8b43f0b5"), Name = "Death", Description = "An effect with the death trait kills you immediately if it reduces you to 0 HP. Some death effects can bring you closer to death or slay you outright without reducing you to 0 HP." };
            yield return new Trait { Id = Guid.Parse("a23df7f5-acc6-4f87-9244-0fbbc77c70d2"), Name = "Detection", Description = "Effects with this trait attempt to determine the presence or location of a person, object, or aura." };
            yield return new Trait { Id = Guid.Parse("0cb3dbbc-941b-4e27-b46c-d0246dacc056"), Name = "Disease", Description = "An effect with this trait applies one or more diseases. A disease is typically an affliction." };
            yield return new Trait { Id = Guid.Parse("1ee8c64b-ad34-4b3b-a01c-a1057eea01f6"), Name = "Emotion", Description = "This effect alters a creature's emotions. Effects with this trait always have the mental trait as well. Creatures with special training or that have mechanical or artificial intelligence are immune to emotion effects." };
            yield return new Trait { Id = Guid.Parse("fc3cb057-dcb6-4508-915a-0abd25679211"), Name = "Evil", Description = "Evil effects often manipulate energy from evil-aligned Outer Planes and are antithetical to good divine servants or divine servants of good deities." };
            yield return new Trait { Id = Guid.Parse("be9994ab-79ef-4ec0-9761-492059b0083a"), Name = "Incapacitation", Description = "An ability with this trait can take a character completely out of the fight or even kill them, and it’s harder to use on a more powerful character. If a spell has the incapacitation trait, any creature of more than twice the spell’s level treats the result of their check to prevent being incapacitated by the spell as one degree of success better, or the result of any check the spellcaster made to incapacitate them as one degree of success worse. If any other effect has the incapacitation trait, a creature of higher level than the item, creature, or hazard generating the effect gains the same benefits." };
            yield return new Trait { Id = Guid.Parse("06f2cf99-b089-4e34-b443-53028fdc2ae0"), Name = "Healing", Description = "A healing effect restores a creature's body, typically by restoring Hit Points, but sometimes by removing diseases or other debilitating effects." };
            yield return new Trait { Id = Guid.Parse("315bf80d-594e-46ca-944e-cb8287df46fa"), Name = "Linguistic", Description = "An effect with this trait depends on language comprehension. A linguistic effect that targets a creature works only if the target understands the language you are using." };
            yield return new Trait { Id = Guid.Parse("2cbfa741-d7b5-465c-98b4-7a6bceae533e"), Name = "Mental", Description = "A mental effect can alter the target’s mind. It has no effect on an object or a mindless creature." };
            yield return new Trait { Id = Guid.Parse("33bf3198-48a1-4559-9a48-9881901f880b"), Name = "Morph", Description = "Effects that slightly alter a creature’s form have the morph trait. Any Strikes specifically granted by a morph effect are magical. You can be affected by multiple morph spells at once, but if you morph the same body part more than once, the second morph effect attempts to counteract the first (in the same manner as two polymorph effects, described in that trait). Your morph effects might also end if you are polymorphed and the polymorph effect invalidates or overrides your morph effect. The GM determines which morph effects can be used together and which can’t." };
            yield return new Trait { Id = Guid.Parse("1a83b706-d9c1-4b46-bcf3-3c9bb82219ee"), Name = "Polymorph", Description = "These effects transform the target into a new form. A target can’t be under the effect of more than one polymorph effect at a time. If it comes under the effect of a second polymorph effect, the second polymorph effect attempts to counteract the first. If it succeeds, it takes effect, and if it fails, the spell has no effect on that target. Any Strikes specifically granted by a polymorph effect are magical. Unless otherwise stated, polymorph spells don’t allow the target to take on the appearance of a specific individual creature, but rather just a generic creature of a general type or ancestry. If you take on a battle form with a polymorph spell, the special statistics can be adjusted only by circumstance bonuses, status bonuses, and penalties. Unless otherwise noted, the battle form prevents you from casting spells, speaking, and using most manipulate actions that require hands. (If there’s doubt about whether you can use an action, the GM decides.) Your gear is absorbed into you; the constant abilities of your gear still function, but you can’t activate any items." };
            yield return new Trait { Id = Guid.Parse("2bc07fcc-2113-4b39-a257-17851f1f216d"), Name = "Plant", Description = "Vegetable creatures have the plant trait. They are distinct from normal plants. Magical effects with this trait manipulate or conjure plants or plant matter in some way. Those that manipulate plants have no effect in an area with no plants." };
            yield return new Trait { Id = Guid.Parse("7684fa81-e3a5-4224-8d57-bc61df53d54a"), Name = "Prediction", Description = "Effects with this trait determine what is likely to happen in the near future. Most predictions are divinations." };
            yield return new Trait { Id = Guid.Parse("4f8453ab-e7f8-4d2f-95e7-e0e53a32cbde"), Name = "Revelation", Description = "Effects with this trait see things as they truly are." };
            yield return new Trait { Id = Guid.Parse("f91abbe0-0bec-4278-99d0-b12f044f8061"), Name = "Scrying", Description = "A scrying effect lets you see, hear, or otherwise get sensory information from a distance using a sensor or apparatus, rather than your own eyes and ears." };
            yield return new Trait { Id = Guid.Parse("340e83a5-5a6e-4a5f-8658-7aede58da5a9"), Name = "Teleportation", Description = "Teleportation effects allow you to instantaneously move from one point in space to another. Teleportation does not usually trigger reactions based on movement." };
            yield return new Trait { Id = Guid.Parse("9979d44e-3a35-4eef-a767-d3c974b5fbf6"), Name = "Fortune", Description = "A fortune effect beneficially alters how you roll your dice. You can never have more than one fortune effect alter a single roll. If multiple fortune effects would apply, you have to pick which to use. If a fortune effect and a misfortune effect would apply to the same roll, the two cancel each other out, and you roll normally." };
            yield return new Trait { Id = Guid.Parse("dee6c869-337c-4f4c-ba3c-3c3e77c19857"), Name = "Manipulate", Description = "You must physically manipulate an item or make gestures to use an action with this trait. Creatures without a suitable appendage can’t perform actions with this trait. Manipulate actions often trigger reactions." };
            yield return new Trait { Id = Guid.Parse("ccae1335-3555-4e55-9fe4-d22f6b9bc162"), Name = "Downtime", Description = "An activity with this trait takes a day or more, and can be used only during downtime" };
            yield return new Trait { Id = Guid.Parse("f7ad867e-49e3-40e3-ad95-bbf461be2087"), Name = "Fear", Description = "Fear effects evoke the emotion of fear. Effects with this trait always have the mental and emotion traits as well." };

            yield return new Trait { Id = Guid.Parse("739ead1c-4020-4673-96d2-4d0b543f6295"), Name = "Curse", Description = "A curse is an effect that places some long-term affliction on a creature. Curses are always magical and are typically the result of a spell or trap. Effects with this trait can be removed only by effects that specifically target curses.  Afflictions with this trait are manifestations of potent ill will.A curse either lasts a specified amount of time or can be removed only by certain actions a character must perform or conditions they must meet.A curse with stages follows the rules for afflictions. (Gamemastery Guide pg. 251)" };
            yield return new Trait { Id = Guid.Parse("39aba859-33a5-45df-b1fe-902f8e3c2273"), Name = "Magical", Description = "Something with the magical trait is imbued with magical energies not tied to a specific tradition of magic. A magical item radiates a magic aura infused with its dominant school of magic.  Some items or effects are closely tied to a particular tradition of magic. In these cases, the item has the arcane, divine, occult, or primal trait instead of the magical trait. Any of these traits indicate that the item is magical." };
            yield return new Trait { Id = Guid.Parse("4b9d47d5-3e89-41ba-8183-9e743c49a41a"), Name = "Sleep", Description = "This effect can cause a creature to fall asleep or get drowsy." };
            yield return new Trait { Id = Guid.Parse("7b601f4a-9c05-426c-aa46-14e8fa989066"), Name = "Virulent", Description = "Afflictions with the virulent trait are harder to remove. You must succeed at two consecutive saves to reduce a virulent affliction’s stage by 1. A critical success reduces a virulent affliction’s stage by only 1 instead of by 2." };
            yield return new Trait { Id = Guid.Parse("897e454f-a75b-448d-a75b-8d6e0f681d11"), Name = "Alchemical", Description = "Alchemical items are powered by reactions of alchemical reagents. Alchemical items aren’t magical and don’t radiate a magical aura." };
            yield return new Trait { Id = Guid.Parse("74d0e1f3-cbab-44df-b024-fdfebb5b27f3"), Name = "Bomb", Description = "An alchemical bomb combines volatile alchemical components that explode when the bomb hits a creature or object. Most alchemical bombs deal damage, though some produce other effects." };
            yield return new Trait { Id = Guid.Parse("00c4abbe-bed2-4e1c-8ef2-826234212f4c"), Name = "Consumable", Description = "An item with this trait can be used only once. Unless stated otherwise, it's destroyed after activation. Consumable items include alchemical items and magical consumables such as scrolls and talismans. When a character creates consumable items, they can make them in batches of four." };
            yield return new Trait { Id = Guid.Parse("7c5d73c4-d239-4cdf-ae95-e3f802156f6b"), Name = "Splash", Description = "When you use a thrown weapon with the splash trait, you don’t add your Strength modifier to the damage roll. If an attack with a splash weapon fails, succeeds, or critically succeeds, all creatures within 5 feet of the target (including the target) take the listed splash damage. On a failure (but not a critical failure), the target of the attack still takes the splash damage. Add splash damage together with the initial damage against the target before applying the target’s weaknesses or resistances. You don’t multiply splash damage on a critical hit." };
            yield return new Trait { Id = Guid.Parse("69712c6e-b328-46e4-a38a-0dc302c469f7"), Name = "Elixir", Description = "Elixirs are alchemical liquids that are used by drinking them." };
            yield return new Trait { Id = Guid.Parse("e3574cce-b028-4a4a-a2c7-fc3e0cfdd4ee"), Name = "Mutagen", Description = "An elixir with the mutagen trait temporarily transmogrifies the subject’s body and alters its mind. A mutagen always conveys one or more beneficial effects paired with one or more detrimental effects. Mutagens are polymorph effects, meaning you can benefit from only one at a time." };
            yield return new Trait { Id = Guid.Parse("67f31585-bba4-4a97-8bfc-ab95013410d4"), Name = "Trap", Description = "A hazard or item with this trait is constructed to hinder interlopers." };
            yield return new Trait { Id = Guid.Parse("86fb6cb4-506a-43c8-99d6-152b9624594f"), Name = "Haunt", Description = "A hazard with this trait is a spiritual echo, often of someone with a tragic death. Putting a haunt to rest often involves resolving the haunt’s unfinished business. A haunt that hasn’t been properly put to rest always returns after a time." };
            yield return new Trait { Id = Guid.Parse("9762a78e-698f-4bbb-81ec-fe1f0784f961"), Name = "Mechanical", Description = "A hazard with this trait is a constructed physical object." };
            yield return new Trait { Id = Guid.Parse("b02d26f9-e334-4f2b-b713-767621853861"), Name = "Environmental", Description = "A hazard with this trait is something dangerous that’s part of the natural world, such as quicksand or harmful mold." };
            yield return new Trait { Id = Guid.Parse("d052779d-0c7e-4fe0-915b-91d3e71fb517"), Name = "Fungus", Description = "Fungal creatures have the fungus trait. They are distinct from normal fungi." };
            yield return new Trait { Id = Guid.Parse("ad251fb5-0c53-47f9-b850-fcefd4cb3165"), Name = "Complex", Description = "A hazard with this trait takes turns in an encounter." };
            yield return new Trait { Id = Guid.Parse("11d74166-043d-4f9d-93eb-8ae813e2b840"), Name = "Deadly", Description = "On a critical hit, the weapon adds a weapon damage die of the listed size. Roll this after doubling the weapon’s damage. This increases to two dice if the weapon has a greater striking rune and three dice if the weapon has a major striking rune. For instance, a rapier with a greater striking rune deals 2d8 extra piercing damage on a critical hit. An ability that changes the size of the weapon’s normal damage dice doesn’t change the size of its deadly die." };

            /*
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            yield return new Trait { Id = Guid.Parse(""), Name = "", Description = "" };
            */
        }
    }
}
