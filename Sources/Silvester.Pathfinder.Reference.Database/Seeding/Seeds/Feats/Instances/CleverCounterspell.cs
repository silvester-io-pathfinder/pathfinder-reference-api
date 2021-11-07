using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleverCounterspell : Template
    {
        public static readonly Guid ID = Guid.Parse("44a69d4d-1861-43a5-a4fc-987bbf339acb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Counterspell",
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
            yield return new TextBlock { Id = Guid.Parse("f3ce6679-2558-4fce-a17c-cb99c9e5fc00"), Type = TextBlockType.Text, Text = "You creatively apply your prepared spells to (Feat: Counterspell) a much wider variety of your opponents’ magic. Instead of being able to counter a foe’s spell with (Feat: Counterspell) only if you have that same spell prepared, you can use (Feat: Counterspell) as long as you have the spell the foe is casting in your spellbook. When you use (Feat: Counterspell) in this way, the prepared spell you expend must share a trait other than its tradition with the triggering spell. At the GM’s discretion, you can instead use a spell that has an opposing trait or that otherwise logically would counter the triggering spell (such as using a cold or water spell to counter (Spell: fireball) or using (Spell: remove fear) to counter a fear spell). Regardless of what spell you expend, you take a -2 penalty to your counteract check, though the GM can waive this penalty if the expended spell is especially appropriate." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("12852c73-7cf1-4c4f-836b-af5b883da6e6"), Feats.Instances.Counterspell.ID);
            builder.HaveSpecificFeat(Guid.Parse("0596a9f9-c896-4127-b9d9-c037b53ee548"), Feats.Instances.QuickRecognition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("230c8bd9-3527-4d66-b495-98ad63b207fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
