using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TombWatchersGlare : Template
    {
        public static readonly Guid ID = Guid.Parse("33240820-a6b3-4a63-9aef-4db99b0e1892");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tomb-Watcher's Glare",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3863af1-fdb8-4af5-bc4a-c77e3680ce4c"), Type = TextBlockType.Text, Text = "When you critically hit an undead creature, or an undead creature critically fails a saving throw against one of your abilities, you drive your divine wrath home in your enemy’s heart. The undead is enfeebled 1 for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("59baa578-24bb-41eb-8f74-28e0f363a650"), Heritages.Instances.DeathWardenDwarf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e70f3ed-680d-499d-895c-fa9949b7d1fc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
