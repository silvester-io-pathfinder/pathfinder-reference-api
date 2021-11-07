using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NecroticInfusion : Template
    {
        public static readonly Guid ID = Guid.Parse("dc42be85-1854-424a-a71c-0bbc54ef1e80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necrotic Infusion",
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
            yield return new TextBlock { Id = Guid.Parse("57f7881e-da8a-4c34-a975-ea46f46d1fee"), Type = TextBlockType.Text, Text = "You pour negative energy into your undead subject to empower its attacks. If the next action you use is to cast (spell: harm) to restore Hit Points to a single undead creature, the target then deals an additional 1d6 negative damage with its melee weapons and unarmed attacks until the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("c64b8ead-8e1d-4f8c-a3dc-140ca2aa2037"), Type = TextBlockType.Text, Text = "If the (spell: harm) spell is at least 5th level, this damage increases to 2d6, and if the (spell: harm) spell is at least 8th level, the damage increases to 3d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("e9ef6b35-9e72-43b3-bc6d-fbf83c5420ac"), DivineFonts.Instances.Harm.ID);
            builder.AddOr(Guid.Parse("0f62f820-4ce3-4f37-85af-4047fcbf76ee"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("599d6f93-9278-4a28-a83d-4dd632423e88"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("b5ef8b92-a06f-40be-8f46-f9173fa9790f"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("d9603fbb-29cc-4ed7-908d-75c89205d4ce"), Alignments.Instances.NeutralEvil.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5305908-b236-4ad9-9759-a9432a538794"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
