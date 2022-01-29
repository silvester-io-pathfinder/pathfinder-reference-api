using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MunitionsCrafter : Template
    {
        public static readonly Guid ID = Guid.Parse("748d0817-1b21-4be5-9ee4-0fb83b6b9fb2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Munitions Crafter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c24d80ba-a533-49ee-9bf6-5dba1122672d"), Type = TextBlockType.Text, Text = $"Bullets and bombs can be scarce in some parts, so you've learned to make your own. You become trained in Crafting and gain the alchemist's infused reagents class feature, gaining a number of reagents each day equal to your level. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Alchemical Crafting", Feats.Instances.AlchemicalCrafting.ID)} feat and four additional formulas for 1st-level alchemical items." };
            yield return new TextBlock { Id = Guid.Parse("5dc026d3-d7ef-4635-a4b3-2baf22d582b2"), Type = TextBlockType.Text, Text = $"You gain infused reagents (a pool of reagents usable to make alchemical items) and advanced alchemy (allowing you to make alchemical items during your daily preparations without the normal cost or time expenditure). You gain batches of infused reagents per day equal to your level, which you can use to create only bombs or alchemical ammunition. Your advanced alchemy level for creating these is 1 and doesn't increase on its own. If you use a batch of infused reagents to create basic level-0 ammunition such as black powder cartridges or black powder doses, you produce 10 rounds of ammunition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f53846c6-db9c-4e0d-9c97-6332231749f7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
