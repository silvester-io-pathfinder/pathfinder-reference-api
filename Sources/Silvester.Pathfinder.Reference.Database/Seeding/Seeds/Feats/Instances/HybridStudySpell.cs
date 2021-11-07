using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HybridStudySpell : Template
    {
        public static readonly Guid ID = Guid.Parse("c7d1a016-203b-44d5-a87d-78da0e71f8eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hybrid Study Spell",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7a9fe95-e953-47ce-81f7-b34d45e6c077"), Type = TextBlockType.Text, Text = "Gain the conflux spell from a hybrid study of your choice. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by studying your spellbook and performing a physical regimen. You don’t gain any of the hybrid study’s other benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d72ff008-1b2d-4fcb-b940-f927dd80b004"), Feats.Instances.MagusDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94b295cf-a24a-4995-97c0-a14058517595"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
