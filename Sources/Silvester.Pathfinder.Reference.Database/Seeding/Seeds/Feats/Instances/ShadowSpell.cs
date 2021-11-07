using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("d5d1a5be-debd-4137-b600-b1ce696c5b49");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e752866-df4d-4dde-8a0e-66517cc020ec"), Type = TextBlockType.Text, Text = "You attach a piece of your shadow to a spell to cloud the senses and cause mischief. If the next action you take is to (action: Cast a Spell) that has the (trait: shadow) trait, choose one creature affected by the spell. This creature either gains a +2 status bonus to Stealth or takes a –2 status penalty to Perception (your choice). This lasts for 1 round. This choice and the effect occur after resolving any checks for the spell’s initial effects. If the chosen creature is your enemy, it’s affected only if your spell attack roll succeeded or if it failed its saving throw." };
            yield return new TextBlock { Id = Guid.Parse("60d92976-2972-48f1-a312-85e914aa65a4"), Type = TextBlockType.Text, Text = "The effects of Shadow Spell end if you use Shadow Spell again." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2258b0c7-6ead-43e0-a3bd-bff3952b5a1d"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33eaecda-8b78-49b2-b22e-31c61d705ce3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
