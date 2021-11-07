using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSafeguards : Template
    {
        public static readonly Guid ID = Guid.Parse("df957f8b-8290-4584-91ec-1cbbbf093e48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Safeguards",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc098c77-cc77-499f-8a7a-dfc88d0c3484"), Type = TextBlockType.Text, Text = "The magic powering you makes it difficult for outside magic to affect you. You gain the (feat: Resist Magic) reaction." };
            yield return new TextBlock { Id = Guid.Parse("8ee7b9d0-41c5-4b7d-80d8-d2528e5ad79d"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("b5905c66-25a9-477d-ac6a-e186bd84050d"), Type = TextBlockType.Text, Text = "~ Enhancement: Your safeguards improve. When you (feat: Resist Magic), you gain a number of temporary Hit Points equal to the spell level of the triggering effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af5c871b-a743-4ff5-9df7-958caab20942"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
