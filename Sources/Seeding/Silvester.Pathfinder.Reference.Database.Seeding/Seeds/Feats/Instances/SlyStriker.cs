using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlyStriker : Template
    {
        public static readonly Guid ID = Guid.Parse("9a27030a-52c3-4529-8083-fa0f63ec17d8");

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
            yield return new TextBlock { Id = Guid.Parse("c86d0a4f-ef5a-4d7f-aab1-bd25a0da8eb8"), Type = TextBlockType.Text, Text = "Your attacks deal more damage, even against creatures that aren’t flat-footed. When you succeed or critically succeed at a (action: Strike) against a creature that isn’t flat-footed, you also deal 1d6 precision damage. This applies only if you’re using a weapon or unarmed attack you could deal sneak attack damage with. At 14th level, if you would normally deal 3d6 or more sneak attack damage to flat-footed creatures, you deal 2d6 precision damage to creatures that aren’t flat-footed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("6f8758bf-9b3d-49bb-891e-a1fa712b122d"), ClassFeatures.Rogues.SneakAttack.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4079e2b0-568e-4166-a60a-7c7e68dca8d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
