using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Planes.Instances
{
    public class Actu : Template
    {
        public static readonly Guid ID = Guid.Parse("429fa72a-4a20-40ce-97b1-b4008807472b");

        protected override Plane GetPlane()
        {
            return new Plane 
            { 
                Id = ID, 
                CategoryId = PlaneCategories.Instances.OuterSpherePlane.ID, 
                AlignmentId = Alignments.Instances.NeutralEvil.ID, 
                Name = "Actu", 
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ca8318d1-5293-43cd-830a-f733f964f34c"), Type = TextBlockType.Text, Text = "A perpetual eclipse looms above the bleak wastelands of Abaddon, shedding an eerie half-light over a landscape of toxic, disease-ridden swamps, volcanic wastes, fog-shrouded forests, and the glittering, memory-devouring ribbon of the River Styx. An unnatural silence blankets the plane, cut only by the wails of petitioners falling from the sky like screaming, falling stars, or those already condemned upon the ground, desperate to find safety that doesn't exist. Daemons, the physical embodiments of death and oblivion, roam unchecked, owing allegiance only to the Four Horsemen of the Apocalypse: Death, Famine, Pestilence, and War. In the courts of the Horsemen and the neutral grounds of trade cities such as Awaiting-Consumption, the soul trade serves daemonic hunger and industrialized oblivion. Night hags and other creatures ply the trade or make their way along the margins of daemonic society, eager to avoid consumption themselves by the plane's nihilistic masters. Urgathoa and Zyphus claim divine domains here, their petitioners granted freedom from predation. Yet something far worse glares down upon these gods and the Horseman alike. Abaddon's perpetual eclipse may be nothing less than the lidded, comatose eye of the Bound Prince, the First Horseman, betrayed and cast down by the Four, forgotten by the cosmos at large, but far too powerful for them to destroy—waiting, watching, and hungering." };
        }
    }
}
