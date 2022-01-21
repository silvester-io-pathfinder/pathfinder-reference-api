using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedCommandUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("ebef6dd7-2712-4a09-b820-6385de458429");

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
            yield return new TextBlock { Id = Guid.Parse("dbaf2a4a-372e-44ec-88ba-d18584eae703"), Type = TextBlockType.Text, Text = "Undead creatures find it all but impossible to resist your commands. When you use (action: Command Undead), if the undead succeeds at its save but doesn't critically succeed, it is your minion for 1 round. If the undead fails its save, it is your minion for 10 minutes. If it critically fails, it is your minion for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("390caa6e-ca53-4979-9b49-d4541d50b04f"), DivineFonts.Instances.Harm.ID);
            builder.HaveSpecificFeat(Guid.Parse("c88f515f-cfb6-4cda-806a-a22cb01206b8"), Feats.Instances.CommandUndead.ID);
            builder.AddOr(Guid.Parse("11c49124-8b2c-4c06-b205-f16f98345542"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("db5108c4-4aaa-4471-8dd0-55f513af69dc"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("45d4e478-77c5-4ae0-9bb0-8c9ab155481d"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("5dc077b9-9498-44e4-ac86-4003d674f8dd"), Alignments.Instances.NeutralEvil.ID);
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
                Id = Guid.Parse("00e902a4-d267-4184-8352-19e0dd7efade"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
