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
    public class ImprovisedRepair : Template
    {
        public static readonly Guid ID = Guid.Parse("8813a069-c1df-4810-815e-fa267f928c67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Repair",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26f97a43-da68-4bc4-bd66-26b9464d9fe5"), Type = TextBlockType.Text, Text = $"You are skilled at making quick fixes to damaged equipment, but your fixes aren't meant to last forever. You make a quick repair to a broken non-magical item in your possession. Until the item takes damage again, you can still use it as a shoddy item of its type. This repair restores no Hit Points, so the item is easy to destroy. Once the item is {ToMarkdownLink<Models.Entities.SkillAction>("Repaired", SkillActions.Instances.Repair.ID)} normally such that it is no longer broken, it is also no longer shoddy." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7cabfac-4670-4738-aee1-ce8032e8d49c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
