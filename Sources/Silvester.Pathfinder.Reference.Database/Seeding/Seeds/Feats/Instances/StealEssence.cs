using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StealEssence : Template
    {
        public static readonly Guid ID = Guid.Parse("681eb006-51a7-426c-805f-aead3a0cf63c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steal Essence",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5063baa-1c85-47d7-973c-ed72d4c72719"), Type = TextBlockType.Text, Text = "Being in the presence of the aeon orbs as they deteriorated has taught you how to siphon energy, and you do so with the required magic item. The DC to steal the properties of a magic item is equal to the DC for the item’s level or the normal DC to (action: Steal) the item, whichever is higher. The targeted item then becomes temporarily immune for 24 hours. If the object was on a creature, that creature is also temporarily immune (which prevents you from attempting to Steal the Essence of another object on it)." };
            yield return new TextBlock { Id = Guid.Parse("708fb615-594b-471e-a684-50c444ae1318"), Type = TextBlockType.Text, Text = "If you successfully steal the properties of an item, it loses its magical properties for 24 hours and you can move those properties to a non-magical object of the same general kind (such as moving a hat’s properties to another piece of headgear or moving a weapon’s properties to another weapon) for the same length of time. If the moved properties are counteracted, they return immediately to the original item. You automatically fail to Steal the Essence of an artifact, cursed item, or similar item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("178b8f67-f18a-4d3e-8e10-f76f947ba9b6"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("7eba2966-7699-4392-9da4-40faaf2d7076"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Thievery.ID);
                or.AddOr(Guid.Parse("2e2c5768-3dc7-49a8-8c5b-46c68bffb902"), or => 
                {
                    or.HaveSpecificSkillProficiency(Guid.Parse("5349e741-864a-421d-92ed-99588824a8e7"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("c43bcdcc-9dee-4876-90ef-a78866c13e63"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("bf15eb43-1171-4493-8249-66435ef2d915"), Proficiencies.Instances.Master.ID, Skills.Instances.Occult.ID);
                    or.HaveSpecificSkillProficiency(Guid.Parse("c033345a-dced-49c3-b420-6d7dafddfee8"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
                });
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
                Id = Guid.Parse("f7bfa382-c12e-405b-ac1f-1b533732aa86"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
