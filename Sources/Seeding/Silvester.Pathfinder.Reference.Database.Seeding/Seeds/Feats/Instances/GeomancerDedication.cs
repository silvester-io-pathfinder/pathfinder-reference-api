using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeomancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bae5a600-deab-446f-99bf-a3b27e0c989b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Geomancer Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the geomancer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87e577ff-ad22-42de-bf26-d1705e337d2e"), Type = TextBlockType.Text, Text = "You feel a deep connection to the world no matter where you are, a phenomenon known as “terrain attunement.” When you expend a spell slot to cast a spell with a trait that corresponds to the type of terrain you are currently in (as listed below), you gain the terrain attunement effect for that type of terrain. The GM might determine an attunement applies as long as it’s prevalent enough around you. For instance, you might be in aquatic terrain on a riverbank or on a boat. Similarly, one place might count as multiple types of terrain, such as a mountain in the far north being both arctic and mountain. In this case, you choose only one terrain attunement effect, even if the spell has traits that would apply to each terrain type." };
            yield return new TextBlock { Id = Guid.Parse("f2037c11-eedc-48ac-8141-1e9a5950dcdd"), Type = TextBlockType.Text, Text = "Certain terrain attunements affect your enemies instead of you. If they do, when you cast the spell you apply the listed effect to all enemies who are either adjacent to you, in the area of the spell, or targeted by the spell. These enemies receive the listed saving throw against your spell DC to attempt to avoid the effect." };
            yield return new TextBlock { Id = Guid.Parse("4920d0c2-b1de-4923-b863-72dd3b7560ea"), Type = TextBlockType.Enumeration, Text = " Aquatic: ((trait: water)) You ride the currents of water. If you’re in the water, you gain a swim Speed equal to your land Speed. If you’re on a surface, temporary waves of water follow your movements, allowing you to use your swim Speed—if you have one—as your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("f35eab1c-b34f-41ab-9b6e-3de6055cbb7c"), Type = TextBlockType.Enumeration, Text = " Arctic: ((trait: cold)) Arctic rime covers your foes’ bodies. Enemies must attempt a Fortitude save. They take a –5-foot status penalty to their Speeds for 2 rounds (–10-foot on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse("5e333a6a-1aa0-4be0-ac81-1269000df606"), Type = TextBlockType.Enumeration, Text = " Desert: ((trait: fire)) The scorching heat of the desert dehydrates your foes. Enemies must attempt a Fortitude save. On a failure, they’re fatigued until they drink water or another potable liquid." };
            yield return new TextBlock { Id = Guid.Parse("4aea8322-c1a4-41bf-8378-61745f8502db"), Type = TextBlockType.Enumeration, Text = " Forest: ((trait: plant)) Branches and vines reach out to get in your foes’ way. Enemies must attempt a Reflex save. On a failure, they become clumsy 1 for 1 round (clumsy 2 on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse("833dce8d-8516-4598-8a57-b4ec1b23681c"), Type = TextBlockType.Enumeration, Text = " Mountain: ((trait: earth)) The rugged endurance of the mountain protects you from harm. You gain resistance to physical damage (except adamantine) equal to the spell level for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("4795b306-7a94-4f9c-ae2e-6a73d4212bbe"), Type = TextBlockType.Enumeration, Text = " Plains: ((trait: plant)) The growing fields and pulsing vitality of the plains provide you vigor. You gain temporary Hit Points equal to the spell level for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("e0d87128-4150-4583-b161-9609bbee815f"), Type = TextBlockType.Enumeration, Text = " Sky: ((trait: air)) A gust of wind carries you aloft. You can (action: Fly) up to 10 feet. If you’re in the air at the end of the turn and don’t have a fly Speed, you fall." };
            yield return new TextBlock { Id = Guid.Parse("bcbb8ec7-9768-47a9-9d21-1496dea981c6"), Type = TextBlockType.Enumeration, Text = " Swamp: ((trait: plant)) Your magic draws in noxious swamp gas to fumigate your foes. Affected foes take persistent poison damage equal to half the spell’s level (minimum 1 damage) with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("bc9588ba-8dce-4017-8afa-50f391b9315c"), Type = TextBlockType.Enumeration, Text = " Underground: ((trait: earth)) The endless darkness of the cavern depths opens up its secrets to your senses. For 1 round, you gain darkvision as well as imprecise tremorsense out to 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a180acbe-9d45-4cc4-89da-0672debf5f7a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.Manual(Guid.Parse("215c53d9-c72f-4d6a-a143-7938e3972101"), "Ability to cast spells from spell slots.");
            builder.AddOr(Guid.Parse("32cdf26b-e595-4732-9740-7aa0df2a75ed"), or => 
            {
                or.HaveAnySpellSpecificTrait(Guid.Parse("74d7b715-1d86-4de6-a2e6-dd954455fbef"), Traits.Instances.Air.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("1f458838-1868-42d2-8204-3e3d1c3a6fa7"), Traits.Instances.Cold.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("766ca463-929a-4864-af07-76d16cc14de3"), Traits.Instances.Earth.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("fcb33287-dfd4-4359-a475-a07a129b9413"), Traits.Instances.Fire.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("6fa16877-5144-44ec-bbac-99bb37b804f1"), Traits.Instances.Plant.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("793f69a9-599f-4e44-a0dd-32606f4fbed0"), Traits.Instances.Water.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b94e8cd8-60ce-4ccc-a3bc-f7dc4c10129e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
