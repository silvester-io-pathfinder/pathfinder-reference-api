using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrixVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("84850c6f-e614-4334-9498-532c6cca827a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strix Vengeance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You, or a strix ally you can see, are damaged by an enemy's critical hit.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9829f482-792f-4270-81f9-d3dcd2e65ed6"), Type = TextBlockType.Text, Text = $"You dedicate yourself to destroying those who harm your kin. Until the end of your next turn, you deal an additional 1d6 damage on {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against the triggering enemy. The bonus increases to 2d6 if you use a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("striking", Items.FundamentalWeaponRunes.Instances.Striking.ID)} weapon or unarmed attack and 3d6 if you use a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("major striking", Items.FundamentalWeaponRunes.Instances.Striking.ID)} weapon or unarmed attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ff969e9-315c-46e7-9c21-239cb64401b0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
