using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeaponSupremacy : Template
    {
        public static readonly Guid ID = Guid.Parse("a8a6b9d4-3df5-464a-9e80-561044b32918");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weapon Supremacy",
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
            yield return new TextBlock { Id = Guid.Parse("1e840d2b-5ddb-47f9-9572-65f5806c1d39"), Type = TextBlockType.Text, Text = "Your skill with weapons lets you attack swiftly at all times." };
            yield return new TextBlock { Id = Guid.Parse("6f25a79b-e51a-4318-b8de-88994ed5ef9d"), Type = TextBlockType.Text, Text = "You’re permanently quickened. You can use your extra action only to (Action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea05930b-2a40-464b-b8d0-574092d7156a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
