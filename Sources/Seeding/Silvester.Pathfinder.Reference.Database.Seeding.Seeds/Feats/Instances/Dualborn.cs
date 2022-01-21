using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dualborn : Template
    {
        public static readonly Guid ID = Guid.Parse("46133b3d-ca25-46c1-8ad0-56a512e5ec30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualborn",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you take the (feat: Elemental Assault) or (feat: Elemental Bulwark) ancestry feats, you can use them only with your chosen elements. You can add your resistance from this feat to the resistance you gain from (feat: Elemental Bulwark) against effects with your elements' traits, for a total of 5 + half your level, or 10 + half your level with (feat: Improved Elemental Bulwark). If you take the (feat: Tetraelemental Assault) feat, you can choose each of your two elements twice each, instead of choosing each of the four elements once each.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95a281a8-083c-4c49-a20f-cd268aa515ba"), Type = TextBlockType.Text, Text = $"Your suli heritage can be traced back to two geniekin ancestors of opposing elements, or to an elemental ancestor that embodied two combined elements. Choose two of the following elements: {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)}, {ToMarkdownLink<Models.Entities.Trait>("earth", Traits.Instances.Earth.ID)}, {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)}. Once made, this choice can't be changed. You gain resistance equal to half your level (minimum 1) to all damaging effects with the traits of either of your chosen elements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecbd6eab-5d41-4246-bac0-cb06bb2a2335"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
