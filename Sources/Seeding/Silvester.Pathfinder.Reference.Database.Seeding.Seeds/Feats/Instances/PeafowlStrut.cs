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
            yield return new TextBlock { Id = Guid.Parse("f1d55b4c-1afd-42be-93a0-8edc479b8880"), Type = TextBlockType.Text, Text = "You slowly move across the battlefield with dangerous grace. (action: Step) twice and then (action: Strike). The (action: Strike) must be made with the sword required by (feat: Peafowl Stance)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0c8ece8f-9f98-4601-a1f7-09594adfe7a5"), Feats.Instances.PeafowlStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
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
