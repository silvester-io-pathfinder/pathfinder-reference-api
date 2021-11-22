using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FatalBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("d78cd63c-aa75-457f-a1c8-984d534abbbe");

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
            yield return new TextBlock { Id = Guid.Parse("eac44740-54b9-42eb-a5eb-013ac936c384"), Type = TextBlockType.Text, Text = "You're especially talented at striking your enemies in their most vulnerable areas. When you critically hit with a (trait: fatal) firearm, you deal an additional die of the appropriate size and damage type for the (trait: fatal) trait after doubling the weapon's damage. For example, after getting a critical hit with a (trait: fatal d12) weapon, you add an additional 1d12 damage to the attack after doubling its damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4b3ed48-0c40-4738-b579-362d8b65bcb4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
