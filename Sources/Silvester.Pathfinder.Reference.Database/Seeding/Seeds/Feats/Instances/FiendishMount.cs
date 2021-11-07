using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishMount : Template
    {
        public static readonly Guid ID = Guid.Parse("f7c6e410-f212-400a-bcd4-51ac6e59a379");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Mount",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8b26282d-0dda-4ea6-a6f2-9df267f07344"), Type = TextBlockType.Text, Text = "Your steed ally manifests a suite of powerful and sinister gifts granted to it by your deity. It gains darkvision, its maximum Hit Points increase by 40, and it gains weakness 10 to good damage." };
            yield return new TextBlock { Id = Guid.Parse("d90ba7a9-940e-4637-9542-03aa7a60c11e"), Type = TextBlockType.Text, Text = "Additionally, it grows wings appropriate for a servitor of your deity (such as bat wings for a devil), granting it a fly Speed equal to its Speed. It gains the fiend trait and the trait appropriate to the type of servitor it has become (such as daemon, demon, or devil)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("c9a6d801-5919-41a9-b417-fb74c3df7aee"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("bded84a9-7952-46c9-95f5-e6e36cdad583"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9efe592f-cd08-4ae0-bcb3-223c31d82b9d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
