using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InnateMagicIntuition : Template
    {
        public static readonly Guid ID = Guid.Parse("0534efcc-8f0e-4592-a476-50093c74afd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Innate Magic Intuition",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32430102-ce51-409c-b6dd-02e72932b203"), Type = TextBlockType.Text, Text = "You&#39;ve spent countless hours learning to recognize and predict a creature&#39;s innate magical abilities. The first time you successfully (action: Recall Knowledge) to identify a creature, in addition to any information you learn from your successful check, you learn the names of three of the highest-level innate spells it can cast, and you gain a +2 circumstance bonus on your next save against an innate spell cast by that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5bb5a21-8b58-486e-884f-d08fc97b060d"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b372f517-824d-4c38-8561-cc901fa5b54c"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
