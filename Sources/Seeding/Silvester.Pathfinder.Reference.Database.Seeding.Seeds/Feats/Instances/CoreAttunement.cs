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
    public class CoreAttunement : Template
    {
        public static readonly Guid ID = Guid.Parse("28661423-d30a-46df-ac4c-1a4f7c83afbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Core Attunement",
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
            yield return new TextBlock { Id = Guid.Parse("af255d82-6809-446d-b4ed-2d4051f8c1f4"), Type = TextBlockType.Text, Text = $"Your core allows you to draw more power from it. Select one 1st-level arcane spell and one 2nd-level or lower arcane spell, to which you have access. You can cast your chosen spells as arcane innate spells each once per day." };
            yield return new TextBlock { Id = Guid.Parse("7fa11d55-0412-48ad-9aff-cd06cf65d176"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("42af5663-084b-4342-9273-a673452616ea"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your attunement grows stronger. Select one 5th-level or lower arcane spell and one 6th-level or lower arcane spell, to which you have access. You can cast them as arcane innate spells each once per day, in addition to the original spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("3a1367de-e158-48de-a51a-27cc81f1cf98"), Heritages.Instances.MageAutomaton.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("770f9c25-fd95-4e72-9457-96158ab60e69"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
