using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelistsChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("d706de94-cddd-4815-a168-e0fe3893d86d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duelist's Challenge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c3fa479-b4da-45c6-ac47-fe228ac09514"), Type = TextBlockType.Text, Text = "Select one foe that you can see and proclaim a challenge. That foe is your dueling opponent until they are defeated, flee, or the encounter ends. Any time you hit that enemy using a single one-handed melee weapon while your other hand or hands are free, you gain a circumstance bonus to the (action: Strike)’s damage equal to the number of damage dice your weapon deals." };
            yield return new TextBlock { Id = Guid.Parse("c2501bca-62cd-4498-ba0b-9a4caccb3fdc"), Type = TextBlockType.Text, Text = "If you attack a creature other than your dueling opponent, you take a circumstance penalty to damage equal to the number of damage dice your weapon deals." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b6ac27d-f7b0-4835-9040-16dee9024207"), Feats.Instances.DuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d70a12d-0b82-45db-87e3-2deb1a33a628"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
