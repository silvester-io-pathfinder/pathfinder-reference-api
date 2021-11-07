using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleSpellcasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("acf0673e-9302-40da-9837-04c695f33ff5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Spellcaster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d021f821-e8f8-4064-acfa-a6fa83127ff5"), Type = TextBlockType.Text, Text = "You now have four cantrips per day instead of three. At 4th level, you have five cantrips per day instead of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("bf8180cb-0e76-40c9-986c-ab572c9fe629"), "Flexible spell preparation.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e9bc890-e5b8-4ea1-a208-d75610b36369"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
