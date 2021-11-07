using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MakerOfMiracles : Template
    {
        public static readonly Guid ID = Guid.Parse("a4bef3a9-7456-45ec-a78d-a80d8411ca37");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Maker of Miracles",
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
            yield return new TextBlock { Id = Guid.Parse("41dc1569-4380-40fd-a8af-d2d046e7ee37"), Type = TextBlockType.Text, Text = "You are a conduit for truly deific power. You gain an additional 10th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("c410f299-964d-423f-adb9-96a4a60c09d1"), ClassFeatures.Clerics.MiraculousSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d5737c4-cb21-4f42-8a3c-ab15779c9b2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
