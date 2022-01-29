using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WyrmsBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("d615b6a2-3387-4445-80ee-a15253268db7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wyrm's Breath",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("113f3301-03be-4509-aba6-e7e943eea4a0"), Type = TextBlockType.Text, Text = $"Your eidolon gathers the power of the mightiest wyrms to make its magical breath even more spectacular. If your eidolon's next action is to use {ToMarkdownLink<Models.Entities.Feat>("Breath Weapon", Feats.Instances.BreathWeapon.ID)}, both the number of damage dice and area of the {ToMarkdownLink<Models.Entities.Feat>("Breath Weapon", Feats.Instances.BreathWeapon.ID)} are doubled." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ac88a5a-92f6-447b-81e1-e69cc354c40c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
