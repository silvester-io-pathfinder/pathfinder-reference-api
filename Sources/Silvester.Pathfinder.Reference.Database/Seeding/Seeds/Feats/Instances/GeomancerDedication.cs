using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeomancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("68c080d7-5e12-4a0b-9d74-2b206d4c8897");

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
            yield return new TextBlock { Id = Guid.Parse("b66f15e3-ef5a-4c10-a070-7cb3f3a74304"), Type = TextBlockType.Text, Text = "You feel a deep connection to the world no matter where you are, a phenomenon known as “terrain attunement.” When you expend a spell slot to cast a spell with a trait that corresponds to the type of terrain you are currently in (as listed below), you gain the terrain attunement effect for that type of terrain. The GM might determine an attunement applies as long as it’s prevalent enough around you. For instance, you might be in aquatic terrain on a riverbank or on a boat. Similarly, one place might count as multiple types of terrain, such as a mountain in the far north being both arctic and mountain. In this case, you choose only one terrain attunement effect, even if the spell has traits that would apply to each terrain type." };
            yield return new TextBlock { Id = Guid.Parse("6cd976c1-98ce-4896-b452-1c1584cc0069"), Type = TextBlockType.Text, Text = "Certain terrain attunements affect your enemies instead of you. If they do, when you cast the spell you apply the listed effect to all enemies who are either adjacent to you, in the area of the spell, or targeted by the spell. These enemies receive the listed saving throw against your spell DC to attempt to avoid the effect." };
            yield return new TextBlock { Id = Guid.Parse("8a5cf430-0c62-4486-b584-f296df872aa3"), Type = TextBlockType.Enumeration, Text = " Aquatic: ((trait: water)) You ride the currents of water. If you’re in the water, you gain a swim Speed equal to your land Speed. If you’re on a surface, temporary waves of water follow your movements, allowing you to use your swim Speed—if you have one—as your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("3c411d49-638b-4ac4-869f-928c6136ab8b"), Type = TextBlockType.Enumeration, Text = " Arctic: ((trait: cold)) Arctic rime covers your foes’ bodies. Enemies must attempt a Fortitude save. They take a –5-foot status penalty to their Speeds for 2 rounds (–10-foot on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse("0401927e-e9e6-4057-bce4-fd2dd5db0ac1"), Type = TextBlockType.Enumeration, Text = " Desert: ((trait: fire)) The scorching heat of the desert dehydrates your foes. Enemies must attempt a Fortitude save. On a failure, they’re fatigued until they drink water or another potable liquid." };
            yield return new TextBlock { Id = Guid.Parse("f633e589-67bf-455d-afc3-74d110fc5954"), Type = TextBlockType.Enumeration, Text = " Forest: ((trait: plant)) Branches and vines reach out to get in your foes’ way. Enemies must attempt a Reflex save. On a failure, they become clumsy 1 for 1 round (clumsy 2 on a critical failure)." };
            yield return new TextBlock { Id = Guid.Parse("11e47da0-4348-4edc-9a69-5f33af8d5c04"), Type = TextBlockType.Enumeration, Text = " Mountain: ((trait: earth)) The rugged endurance of the mountain protects you from harm. You gain resistance to physical damage (except adamantine) equal to the spell level for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("e2f765a3-fb26-45c7-ad9e-6e83b2d6342b"), Type = TextBlockType.Enumeration, Text = " Plains: ((trait: plant)) The growing fields and pulsing vitality of the plains provide you vigor. You gain temporary Hit Points equal to the spell level for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("18b9eea8-4232-471d-9dba-cc9213e25293"), Type = TextBlockType.Enumeration, Text = " Sky: ((trait: air)) A gust of wind carries you aloft. You can (action: Fly) up to 10 feet. If you’re in the air at the end of the turn and don’t have a fly Speed, you fall." };
            yield return new TextBlock { Id = Guid.Parse("bf58af63-5896-41bb-aae1-01ecc538f754"), Type = TextBlockType.Enumeration, Text = " Swamp: ((trait: plant)) Your magic draws in noxious swamp gas to fumigate your foes. Affected foes take persistent poison damage equal to half the spell’s level (minimum 1 damage) with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("404bb377-7aed-47ae-96d5-d2b6733f8757"), Type = TextBlockType.Enumeration, Text = " Underground: ((trait: earth)) The endless darkness of the cavern depths opens up its secrets to your senses. For 1 round, you gain darkvision as well as imprecise tremorsense out to 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4447fbb9-5997-45e3-87bd-b7393044fbf4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.Manual(Guid.Parse("fe86b88c-5336-440a-afcc-1db5050288cc"), "Ability to cast spells from spell slots.");
            builder.AddOr(Guid.Parse("e44adfcd-19fd-4218-bb5d-5603297de6c4"), or => 
            {
                or.HaveAnySpellSpecificTrait(Guid.Parse("f61d0f40-f20a-48f3-bf50-bdcf7698eb12"), Traits.Instances.Air.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("c44722ba-5441-4740-b281-58a644c995d8"), Traits.Instances.Cold.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("c2ce2994-14c1-41d7-a4dc-8fe6c343c22f"), Traits.Instances.Earth.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("662fa112-93d4-4137-ac87-0e139331f642"), Traits.Instances.Fire.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("3fee199d-bd1d-4d63-92d1-1590fb4f33f7"), Traits.Instances.Plant.ID);
                or.HaveAnySpellSpecificTrait(Guid.Parse("b310659b-2ec6-4bc9-942a-6c84856931cf"), Traits.Instances.Water.ID);
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
                Id = Guid.Parse("fc2f3ff5-6849-4ee6-947d-2586a6441ab3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
