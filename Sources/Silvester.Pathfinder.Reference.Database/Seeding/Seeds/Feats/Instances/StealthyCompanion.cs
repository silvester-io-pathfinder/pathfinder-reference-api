using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StealthyCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("5328f240-8772-405d-8ea5-e2a293dc9c65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stealthy Companion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9eb3ed82-23da-479d-a839-14149b3c9bfd"), Type = TextBlockType.Text, Text = "You’ve trained your animal companion to blend in to its surroundings. Your animal companion gains the benefit of the (feat: Camouflage) feat. If your companion is a specialized ambusher, its proficiency rank for Stealth increases to master (or legendary if it was already master)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyAnimalCompanion(Guid.Parse("12173b79-670e-4b63-b27c-3248a235b2f1"));
            builder.HaveSpecificFeat(Guid.Parse("5c1c70a3-01fd-46be-88ae-f82a86c7262b"), Feats.Instances.Camouflage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9535ebd-ceb5-46bc-aab5-c42c8203618b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
