using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterMagicalEdification : Template
    {
        public static readonly Guid ID = Guid.Parse("c3bc87de-6302-454a-9bb7-8e58ce76b438");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Magical Edification",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b02e578-b40b-4465-8ad8-a5d559945e9a"), Type = TextBlockType.Text, Text = "You’ve continued to expand your compendium of tools to compile knowledge. You can cast (spell: comprehend language), (spell: mindlink), and (spell: secret page) as innate occult spells, each once per day. When you cast (spell: secret page), it is automatically heightened to the same spell level as your cantrips from (feat: Magical Edification)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("52099d06-5efc-45e4-b42f-68bc05b43bf1"), Feats.Instances.MagicalEdification.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("850aebaf-8a27-443a-a503-206cf186ac85"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
