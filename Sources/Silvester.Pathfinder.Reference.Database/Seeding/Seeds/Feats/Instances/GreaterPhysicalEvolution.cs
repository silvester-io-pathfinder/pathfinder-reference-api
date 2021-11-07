using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterPhysicalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("9f75ad0e-3ed9-4f6e-b53c-0526b3f1b3dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Physical Evolution",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b37966a-00fc-40b4-a0ae-bd37ae24a4b4"), Type = TextBlockType.Text, Text = "You hold a deep understanding of the innate fundamental structures of the physical world, and you can enforce your will upon that structure as far as your own blood is concerned. Once per day, you can use a sorcerer spell slot to cast any common polymorph battle form spell of the spell slot’s level as if it were a signature spell in your repertoire." };
            yield return new TextBlock { Id = Guid.Parse("5d965082-3a34-4a39-9012-8356560e919b"), Type = TextBlockType.Text, Text = "If you have (feat: Arcane Evolution), you can also choose from any battle form spell in your spellbook. If you have (feat: Primal Evolution), you can (activity: Cast a Spell) listed in that feat using the extra spell slot the feat grants (instead of a sorcerer spell slot)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("daa75527-122e-457e-b77d-8290f2c7a936"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("358c87d1-7a96-4c3b-b802-41842e39fb62"), Feats.Instances.ArcaneEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("61c5a359-dbc5-4f87-ade5-63e175bdcd14"), Feats.Instances.PrimalEvolution.ID);
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
                Id = Guid.Parse("d453f0ea-0de1-4a57-a02c-ab7ae0dfbbaa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
