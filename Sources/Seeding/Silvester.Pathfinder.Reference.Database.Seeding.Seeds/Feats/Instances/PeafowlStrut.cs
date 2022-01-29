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
    public class PeafowlStrut : Template
    {
        public static readonly Guid ID = Guid.Parse("4036596c-70e1-4367-8a05-59073b00fb29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peafowl Strut",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1d55b4c-1afd-42be-93a0-8edc479b8880"), Type = TextBlockType.Text, Text = $"You slowly move across the battlefield with dangerous grace. {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} twice and then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} must be made with the sword required by {ToMarkdownLink<Models.Entities.Feat>("Peafowl Stance", Feats.Instances.PeafowlStance.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0c8ece8f-9f98-4601-a1f7-09594adfe7a5"), Feats.Instances.PeafowlStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("809eb227-7e6f-43f5-93a8-9cf416619351"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("b781af15-fc94-483b-81fc-82d270e24205"), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f144451-70a9-472b-9890-afe775b18264"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
