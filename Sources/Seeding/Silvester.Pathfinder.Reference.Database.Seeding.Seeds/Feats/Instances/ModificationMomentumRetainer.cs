using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMomentumRetainer : Template
    {
        public static readonly Guid ID = Guid.Parse("d0ff8bdf-7e02-4c77-a4ae-4bf375c9535d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Momentum Retainer",
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
            yield return new TextBlock { Id = Guid.Parse("27bf7a62-a84d-47dc-959c-0d9965f8219c"), Type = TextBlockType.Enumeration, Text = $"*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("516fcb69-b266-4825-ba41-d11833539c29"), Type = TextBlockType.Text, Text = $"A special weighted device lets your weapon retain more of its momentum when you attack. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("forceful", Traits.Instances.Forceful.ID)} and {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)} traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6776c2c9-7dd6-4eb1-81cb-35cd9e1496ba"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
