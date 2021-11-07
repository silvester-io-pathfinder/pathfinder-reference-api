using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BladeOfTheCrimsonOath : Template
    {
        public static readonly Guid ID = Guid.Parse("56ee3d63-2445-4d87-83df-30568ee1dbf4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blade of the Crimson Oath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c14f64bd-9e0e-4d10-ba51-fa055caaa726"), Type = TextBlockType.Text, Text = "You call upon the Crimson Oath to smite undead and then make a weapon or unarmed (action: Strike) against an undead foe. The (action: Strike) deals two extra weapon damage dice, and you can convert all the physical damage from the attack into positive damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fcb4ec61-163d-43dc-a883-ed428d2334e7"), Feats.Instances.KnightReclaimantDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf9b903c-5737-48ec-8ca9-3417f2bf3e4a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
