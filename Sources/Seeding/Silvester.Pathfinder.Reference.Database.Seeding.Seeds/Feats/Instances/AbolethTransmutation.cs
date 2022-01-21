using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbolethTransmutation : Template
    {
        public static readonly Guid ID = Guid.Parse("dad3fb09-e0c3-4d3e-a73d-35dae5b831bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aboleth Transmutation",
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
            yield return new TextBlock { Id = Guid.Parse("83cb8a0a-f530-4c27-82bd-b58f05435131"), Type = TextBlockType.Text, Text = $"You have tapped into the ancient magic used by alghollthu masters (also known as aboleths) to mold the flesh of your ancestors. You can use this magic to transfigure other beings. You gain 3rd-level {ToMarkdownLink<Models.Entities.Spell>("feet to fins", Spells.Instances.FeetToFins.ID)} and 2nd-level {ToMarkdownLink<Models.Entities.Spell>("water breathing", Spells.Instances.WaterBreathing.ID)} as arcane innate spells. You can cast each of these arcane innate spells once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28b4a3d5-ee04-463e-8702-979d2770166a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
