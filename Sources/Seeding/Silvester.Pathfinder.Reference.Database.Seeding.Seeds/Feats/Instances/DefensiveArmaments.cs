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
    public class DefensiveArmaments : Template
    {
        public static readonly Guid ID = Guid.Parse("b642c660-072a-42c7-9eef-f8b13cffd53c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Armaments",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("372e837e-7254-4072-9808-0f6d26b5e784"), Type = TextBlockType.Text, Text = $"You use bulky firearms or crossbows to shield your body from your foes' attacks. Any two-handed firearms and two-handed crossbows you wield gain the {ToMarkdownLink<Models.Entities.Trait>("parry", Traits.Instances.Parry.ID)} trait. If an appropriate weapon already has the {ToMarkdownLink<Models.Entities.Trait>("parry", Traits.Instances.Parry.ID)} trait, increase the circumstance bonus to AC it grants when used to parry from +1 to +2." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4478bbce-6a3d-417f-9d50-2af7ba4f8106"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00bcbe82-1a0d-480d-a218-635a784b6959"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
