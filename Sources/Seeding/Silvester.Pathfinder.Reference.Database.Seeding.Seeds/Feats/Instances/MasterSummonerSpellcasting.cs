using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("970b574f-87e1-4bc9-95aa-279865ffe7c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Summoner Spellcasting",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("947f3443-6555-4a98-8e81-526f2b84ec44"), Type = TextBlockType.Text, Text = $"Your proficiency ranks for your tradition's spell attack rolls and spell DCs increase to master. You gain an additional 6th-level spell slot. At 20th level, you replace your two 5th-level spell slots with two 7th-level spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("05cdc505-4422-4b08-9b72-fba41e2064a4"), Feats.Instances.ExpertSummonerSpellcasting.ID);
            builder.Manual(Guid.Parse("8f6fb770-baf1-4504-a8f9-b52d0cb0c398"), "Legendary in the skill associated with your eidolon's tradition.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29bef3f9-ce56-4dfb-97a4-a90b3dc8cf39"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
