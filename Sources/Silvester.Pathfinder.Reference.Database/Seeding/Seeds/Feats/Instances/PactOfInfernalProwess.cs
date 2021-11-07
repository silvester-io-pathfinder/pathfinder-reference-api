using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PactOfInfernalProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("09836f09-3de0-40f9-9d4e-179a6980b555");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pact of Infernal Prowess",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't retrain out of a Pact of Infernal Prowess without journeying to Hell and destroying the devil's written contract spelling out the terms of your pact.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08d7d3b4-bb66-4c0d-9804-ed90ab42c312"), Type = TextBlockType.Text, Text = "You’ve sworn a pact with devils, granting you success in life in exchange for your soul in the afterlife. Once per day, when you critically fail a check, you can reroll the check as a free action; this is a (trait: fortune) effect. Additionally, you can choose to automatically succeed at checks to (action: Earn Income) for tasks below your level, without rolling." };
            yield return new TextBlock { Id = Guid.Parse("abbbee9f-f1f3-4548-8861-7b12358cf1af"), Type = TextBlockType.Text, Text = "However, when you die, your soul is consigned to Hell. You can’t be returned to life except by powerful magic such as (spell: miracle), and even then, the devils responsible for the contract can track your every move for 1 year. The devils gain the effects of a (spell: discern location) spell. They can also use 10th-level (spell: scrying) on you at will, and you automatically critically fail your saving throw." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85a47ea5-ef97-4a85-88d9-4a1273a04864"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
