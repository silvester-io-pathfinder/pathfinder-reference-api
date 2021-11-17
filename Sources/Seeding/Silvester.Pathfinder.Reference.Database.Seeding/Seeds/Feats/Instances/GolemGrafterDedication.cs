using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GolemGrafterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("eb5ed88b-c55e-4e80-9015-514805d18290");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golem Grafter Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the golem grafter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1deb3fc-1a5a-4cc0-8f75-b310f01e3531"), Type = TextBlockType.Text, Text = "Your flesh has been specially treated with the same arcane and alchemical processes used to toughen the skin of flesh golems. Increase your maximum Hit Points by an amount equal to your level. You gain resistance to physical damage (except adamantine) equal to your number of class feats from the golem grafter archetype." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("f60972b9-8838-4a03-a9ed-5b5cb9135dd1"), or => 
            {
                or.AddAnd(Guid.Parse("fdb818d8-b63b-456c-a3ea-13105dfe1b33"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("2604ab51-7696-4497-a444-24e87f4aaf92"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("1a437eb9-34d7-43c9-bf63-04acc68d937c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
                });
                //TODO: Add prerequisites.
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
                Id = Guid.Parse("fdd9e054-88b8-407e-95a5-5fad9bc2b0e7"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
