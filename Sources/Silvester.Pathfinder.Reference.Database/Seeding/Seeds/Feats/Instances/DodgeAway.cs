using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DodgeAway : Template
    {
        public static readonly Guid ID = Guid.Parse("3ac6298c-e707-4c96-a39f-0171e21ca5d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dodge Away",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are the target of a melee attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6cbfef3e-6b54-4027-b999-99cffa8bde99"), Type = TextBlockType.Text, Text = "You use your acrobatic prowess to evade an attack, using momentum to keep yourself moving, if you choose. You gain a +1 circumstance bonus to AC against the triggering attack. If the attack misses you, you can (action: Step) after the (action: Strike). If you’re a master in Acrobatics, you can move 10 feet on this (action: Step) instead of 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7f6fc6df-a6c3-42b4-ac40-02900adf8b9a"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c83431ba-6c09-46ab-8ea4-e47858b0432c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
