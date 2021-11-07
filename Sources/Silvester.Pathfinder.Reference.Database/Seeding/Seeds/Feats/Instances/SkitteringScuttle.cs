using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkitteringScuttle : Template
    {
        public static readonly Guid ID = Guid.Parse("3700f707-9a05-4c50-be88-8de2a71b6169");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skittering Scuttle",
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
            yield return new TextBlock { Id = Guid.Parse("6e98baf5-1543-4e0c-b83f-d1b92b47575a"), Type = TextBlockType.Text, Text = "You can scuttle farther and faster when maneuvering alongside allies. When you use (action: Goblin Scuttle), you can (action: Stride) up to half your Speed instead of (action: Stepping | Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f96bf12-f05c-4c0c-a72d-b4e9b54ac235"), Feats.Instances.GoblinScuttle.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86721252-d714-44d4-b453-f9369c9adb75"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
