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
    public class AutomatonLore : Template
    {
        public static readonly Guid ID = Guid.Parse("5440da8f-266a-49ca-b45d-82756db091a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Lore",
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
            yield return new TextBlock { Id = Guid.Parse("015ae112-7fab-4d72-90bb-d837e122cf25"), Type = TextBlockType.Text, Text = $"You have come to better understand the process that made your body and the magic that powers it. You gain the trained proficiency rank in Arcana and Crafting. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Automaton Lore." };
            yield return new TextBlock { Id = Guid.Parse("8b33ce03-975c-4c7a-928f-4f7d7663009e"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("b724b517-ee30-4a5f-93c6-cfe3b635255e"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your gain greater understanding. Increase your proficiency rank in either Arcana or Crafting, as well as Automaton Lore, to expert. If you were already an expert in the chosen skill, increase your rank to master instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87567d93-8c6e-4b14-9d71-1d86f5e64f2b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
