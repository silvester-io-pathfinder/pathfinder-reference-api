using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationDynamicWeighting : Template
    {
        public static readonly Guid ID = Guid.Parse("dff07413-a6e2-48bc-8f43-6fd85558c3a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Dynamic Weighting",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4bd404d2-d3b8-4560-981d-89eeec9b06a1"), Type = TextBlockType.Enumeration, Text = $"*One-handed Melee Weapon Only; Can't Have the {ToMarkdownLink<Models.Entities.Trait>("Agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("Attached", Traits.Instances.Attached.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("Free-hand", Traits.Instances.FreeHand.ID)} Trait**" };
            yield return new TextBlock { Id = Guid.Parse("8e00f757-3c24-4b5c-a35c-23c8a8c795bf"), Type = TextBlockType.Text, Text = $"Your weapon's modified weight distribution can increase power in exchange for taking more hands to wield. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("two-hand", Traits.Instances.TwoHand.ID)} trait, with a damage die one size higher than the weapon's normal weapon damage die size (for instance, a longsword would gain the {ToMarkdownLink<Models.Entities.Trait>("two-hand", Traits.Instances.TwoHand.ID)} d10 trait). Your innovation also gains the {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)} trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d641d4e-7846-4d33-ab8e-370816f8e1ad"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
