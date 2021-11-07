using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RapidMantel : Template
    {
        public static readonly Guid ID = Guid.Parse("888675db-9069-4b46-8856-c88b5c824077");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rapid Mantel",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("841b678a-2e30-4fdf-bddd-019cc82f4ecb"), Type = TextBlockType.Text, Text = "You easily pull yourself onto ledges. When you (action: Grab an Edge), you can pull yourself onto that surface and stand. You can use Athletics instead of a Reflex save to (action: Grab an Edge)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f19e7ba5-59e5-4c9e-9f88-e6a6ce12e2cb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fd767b0-03b3-4293-bc2e-120f033b7e19"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
