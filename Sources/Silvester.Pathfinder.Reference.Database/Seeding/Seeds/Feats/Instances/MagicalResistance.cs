using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("17de44c4-f272-41da-a6da-28f04a18d182");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Resistance",
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
            yield return new TextBlock { Id = Guid.Parse("bce8fef4-a32b-413e-a5da-fa3320c38b1b"), Type = TextBlockType.Text, Text = "Your animating magic provides some defense. Choose one of the following energy damage types: cold, electricity, or sonic. You gain resistance 5 to that damage type." };
            yield return new TextBlock { Id = Guid.Parse("14318eb5-95a8-49e5-aaea-f6f3cdceb73d"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("48df90ea-b61e-4bff-bc11-ea5914327219"), Type = TextBlockType.Text, Text = "~ Enhancement: You tap deeper into your animating magic, and your resistances improve. Choose one of the following benefits: you gain resistance 5 to the remaining two damage types from the above list, or your chosen resistance increases to a value equal to 1 + half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33b13b36-5ed1-4893-b802-0f978ec4dda4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
