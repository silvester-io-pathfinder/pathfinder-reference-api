using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JugglerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("829bf5d8-8ced-4ab9-98eb-140a1b988242");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Juggler Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained one other feat from the juggler archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18369267-26e1-4854-afef-15c54801091f"), Type = TextBlockType.Text, Text = "You become trained in Performance; if you were already trained in Performance, you instead become trained in a skill of your choice. You also gain the (feat: Juggle) skill feat, even if you don’t meet its prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("ffc144e5-ff5b-4ed6-8719-632fdacb6068"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7eba13bc-8ffd-4bd9-93ba-9d64151c783f"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
