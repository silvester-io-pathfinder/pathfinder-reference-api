using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyBlessed : Template
    {
        public static readonly Guid ID = Guid.Parse("79e386ab-345e-4477-bbcc-ca3eb07535cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Blessed",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("169eff14-aca7-4bff-a6be-d7374bcb1a2a"), Type = TextBlockType.Text, Text = "Energy runs through your blood more powerfully. When you use (feat: Energy Emanation), you can create an emanation of 5 feet, 10 feet, or 15 feet. The damage increases to 6d6 plus an additional 1d6 for every level you have above 9th, instead of 1d6 plus an additional 1d6 for every 2 levels above 1st." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("686d958d-3a0d-4470-ba26-f66b47a47707"), Heritages.Instances.ElementalHeartDwarf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e862b83a-9de4-4fe3-85f8-6caaf2ae35b9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
