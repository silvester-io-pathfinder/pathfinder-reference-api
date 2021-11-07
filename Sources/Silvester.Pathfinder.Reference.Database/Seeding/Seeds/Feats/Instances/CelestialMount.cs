using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialMount : Template
    {
        public static readonly Guid ID = Guid.Parse("8c840d71-ee29-4126-964b-79fc2331c717");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Mount",
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
            yield return new TextBlock { Id = Guid.Parse("8a018495-0ce5-43b3-8aa8-2cabc3f58582"), Type = TextBlockType.Text, Text = "Your steed gains incredible celestial powers granted by your deity. It gains darkvision, its maximum Hit Points increase by 40, and it gains weakness 10 to evil damage." };
            yield return new TextBlock { Id = Guid.Parse("920dbaad-8f4d-4f92-8bd9-b5ce09ea0cad"), Type = TextBlockType.Text, Text = "Additionally, it grows wings appropriate to a servitor of your deity (such as metallic wings for an archon), granting it a fly Speed equal to its Speed. It gains the (trait: celestial) trait and the trait appropriate to the type of servitor it has become (archon, angel, or azata, for example)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("5d9ecf9f-51d4-4379-8491-c91b67249107"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("6406711a-284e-4543-a3d9-4684776c14b1"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baad80f3-23f1-40be-9a92-c2bdde57d430"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
