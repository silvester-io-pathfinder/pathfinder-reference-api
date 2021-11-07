using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchwizardsMight : Template
    {
        public static readonly Guid ID = Guid.Parse("d1e2d569-89ba-418c-8451-bcef9aba1783");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archwizard's Might",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb92bfba-5bb3-45cb-b212-ffff9f1c5101"), Type = TextBlockType.Text, Text = "You have mastered the greatest secrets of arcane magic. You gain an additional 10th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("cfa9df76-6250-419b-847b-069fa7f41c32"), ClassFeatures.Wizards.ArchwizardsSpellcraft.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21045fad-faf3-4f06-8590-a7f3addd992e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
