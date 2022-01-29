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
    public class DeterminedDash : Template
    {
        public static readonly Guid ID = Guid.Parse("d3b42175-33df-441f-9eae-246e73ea9308");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Determined Dash",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c66d755c-9eb9-42e6-83f9-5732155a83c4"), Type = TextBlockType.Text, Text = $"Nothing can keep you from your enemy. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} twice. During this movement you ignore difficult terrain, greater difficult terrain, and any effects that would impose a penalty to Speed. You can attempt an Athletics check instead of an Acrobatics check to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)} when moving across narrow surfaces or uneven ground, using the same DC. This doesn't prevent you from being harmed by hazardous terrain. You can increase the number of actions this activity takes to 3 to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} three times instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fa56544-1d18-40b0-a22c-79d3574dae6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
