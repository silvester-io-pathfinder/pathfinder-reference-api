using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedCommandUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("637ea7c5-421b-488e-ae78-94cbd92f0b96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Command Undead",
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
            yield return new TextBlock { Id = Guid.Parse("e7d85bd0-db0e-49b0-b411-9955a96c7e26"), Type = TextBlockType.Text, Text = "Undead creatures find it all but impossible to resist your commands. When you use (action: Command Undead), if the undead succeeds at its save but doesn’t critically succeed, it is your minion for 1 round. If the undead fails its save, it is your minion for 10 minutes. If it critically fails, it is your minion for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("3e2c2837-084b-4a73-9c72-6c3013aade56"), DivineFonts.Instances.Harm.ID);
            builder.HaveSpecificFeat(Guid.Parse("f2706741-5dcf-43ce-ba58-762215f7d165"), Feats.Instances.CommandUndead.ID);
            builder.AddOr(Guid.Parse("94754d11-6e27-45b3-a8c2-9797fcf9bac1"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("f69c2f38-de5b-4a05-9538-780f48c17576"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("54b4984b-0407-49a3-9ff0-75054e71ca0d"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("3480493b-e30c-4f8f-9e18-ba64b95de3a9"), Alignments.Instances.NeutralEvil.ID);
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
                Id = Guid.Parse("7b2b5be5-3085-4018-9050-4878f456a08b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
