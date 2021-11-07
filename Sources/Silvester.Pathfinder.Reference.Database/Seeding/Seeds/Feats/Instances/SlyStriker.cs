using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlyStriker : Template
    {
        public static readonly Guid ID = Guid.Parse("8dea2b57-9dc7-4d7f-ad38-b33ceb6a37af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sly Striker",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca3c16c0-db8c-4087-b36a-3b009b9f2eab"), Type = TextBlockType.Text, Text = "Your attacks deal more damage, even against creatures that aren’t flat-footed. When you succeed or critically succeed at a (action: Strike) against a creature that isn’t flat-footed, you also deal 1d6 precision damage. This applies only if you’re using a weapon or unarmed attack you could deal sneak attack damage with. At 14th level, if you would normally deal 3d6 or more sneak attack damage to flat-footed creatures, you deal 2d6 precision damage to creatures that aren’t flat-footed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("cd51c3d1-36c5-4b27-80d1-81a7b9b4d1da"), ClassFeatures.Rogues.SneakAttack.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6baa8fb-a0d9-43f6-9b9e-f5afc2cb50b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
