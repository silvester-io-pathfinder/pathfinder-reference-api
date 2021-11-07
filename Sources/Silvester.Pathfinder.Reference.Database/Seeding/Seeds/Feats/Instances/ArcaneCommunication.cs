using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneCommunication : Template
    {
        public static readonly Guid ID = Guid.Parse("fb63cb9b-bd48-490d-91a5-2c0960c2c219");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Communication",
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
            yield return new TextBlock { Id = Guid.Parse("72d721f9-8323-49a8-9b6c-716549cc63fe"), Type = TextBlockType.Text, Text = "You can deliver silent messages. You gain touch telepathy, allowing you to communicate silently and mentally with any creature you’re touching, as long as you share a language." };
            yield return new TextBlock { Id = Guid.Parse("77c0aad9-bf8d-42b7-92a8-ffe4fa3657f9"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("9577e89f-672c-4c76-91d7-4a264417863c"), Type = TextBlockType.Text, Text = "~ Enhancement: You can send your messages even further. Your telepathy gains a range of 10 feet, but you still have to share a language with your target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d6b5eb9-a292-4015-9ef8-6429a1d43f00"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
