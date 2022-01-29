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
    public class CommunalSustain : Template
    {
        public static readonly Guid ID = Guid.Parse("b56ea191-fe20-4b55-886c-d95f6ae76d91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Communal Sustain",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("333ba666-fcf1-4e8b-a462-e4c22173bdaa"), Type = TextBlockType.Text, Text = $"Choose one spell with a sustained duration that one of your allies has in effect. You must be within 30 feet of the chosen ally. The ally can {ToMarkdownLink<Models.Entities.Action>("Sustain the Spell", Actions.Instances.SustainASpell.ID)} once as a free action, triggered at the start of their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8dc6a80a-3d91-4efa-9a8c-af121645c268"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("059dbde8-0801-430e-b521-6f18a667dd22"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
