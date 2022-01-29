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
    public class ElementalAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("cdfce562-5c3b-41df-8be2-4cd57e9549a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Assault",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55c364f1-d1f5-488a-ae07-8d92384ce79d"), Type = TextBlockType.Text, Text = $"You shroud your arms and held weapons in elemental magic. Choose one element. Until the end of your next turn, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} deal an additional 1d6 damage of the indicated type and have the trait corresponding to the element: electricity for {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)}, bludgeoning for {ToMarkdownLink<Models.Entities.Trait>("earth", Traits.Instances.Earth.ID)}, fire for {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)}, or cold for {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56a3f566-20a5-430d-b48b-e88f9d453be0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
