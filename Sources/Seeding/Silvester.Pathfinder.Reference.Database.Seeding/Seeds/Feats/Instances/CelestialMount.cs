using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialMount : Template
    {
        public static readonly Guid ID = Guid.Parse("31291e46-522b-4d70-a543-adedb996f3bc");

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
            yield return new TextBlock { Id = Guid.Parse("7adefbe7-ad31-4e6b-b3dd-7d38cc7cbef1"), Type = TextBlockType.Text, Text = "Your steed gains incredible celestial powers granted by your deity. It gains darkvision, its maximum Hit Points increase by 40, and it gains weakness 10 to evil damage." };
            yield return new TextBlock { Id = Guid.Parse("524b32c2-1ebd-4f2e-b430-f4544905d32e"), Type = TextBlockType.Text, Text = "Additionally, it grows wings appropriate to a servitor of your deity (such as metallic wings for an archon), granting it a fly Speed equal to its Speed. It gains the (trait: celestial) trait and the trait appropriate to the type of servitor it has become (archon, angel, or azata, for example)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("ec0d2850-dc62-4ff4-bea9-153b5b4f8ffd"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("0d2b6096-2f7b-4960-9c76-0374a472c3b9"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bdcf011-37d5-4e62-829e-e468e008a0a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}