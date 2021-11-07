using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FatalBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("4d9b8a82-f81c-4d9c-aa19-414a5ebc411d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fatal Bullet",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("652367e0-f689-440e-9bc3-0a121976dc07"), Type = TextBlockType.Text, Text = "You’re especially talented at striking your enemies in their most vulnerable areas. When you critically hit with a (trait: fatal) firearm, you deal an additional die of the appropriate size and damage type for the (trait: fatal) trait after doubling the weapon’s damage. For example, after getting a critical hit with a (trait: fatal d12) weapon, you add an additional 1d12 damage to the attack after doubling its damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd37368c-6b51-46d9-847a-7c6ba60e52e5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
